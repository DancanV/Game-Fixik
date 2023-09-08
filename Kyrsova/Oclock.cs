using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kyrsova.Class;
using Newtonsoft.Json;

namespace Kyrsova
{
    public partial class Oclock : Form
    {
        FlyWeightImage Gear = new FlyWeightImage(6);
        FlyWeightImage FonOclock = new FlyWeightImage(5);
        int[,] IndexGear = new int[5, 3];
        List<Rectangle> ArrayRectangle = new List<Rectangle>();
        private bool isDragging = false;
        private Point startPoint;
        private Point startLocation;
        byte index;
        int sec = 25;
        int TimerCheck = 0;
        int bonus;
        bool swicher = true;
        GameControl TimeBonus = new GameControl();
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4; 
        private Point p5;
        private Point p6;
        public Oclock()
        {
            InitializeComponent();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is PictureBox)
                {
                    Controls[i].BackColor = Color.Transparent;
                }
            }
            IndexGear[0, 0] = 3;
            IndexGear[0, 1] = 2;
            IndexGear[0, 2] = 1;
            IndexGear[1, 0] = 5;
            IndexGear[1, 1] = 0;
            IndexGear[1, 2] = 2;
            IndexGear[2, 0] = 3;
            IndexGear[2, 1] = 5;
            IndexGear[2, 2] = 4;
            IndexGear[3, 0] = 5;
            IndexGear[3, 1] = 1;
            IndexGear[3, 2] = 4;
            ArrayRectangle.Add(new Rectangle(471,324,527,386));
            ArrayRectangle.Add(new Rectangle(462,393,567,494));
            ArrayRectangle.Add(new Rectangle(504,162,640,277));
            ArrayRectangle.Add(new Rectangle(319,274,475,438));
            ArrayRectangle.Add(new Rectangle(459,146,534,203));
            ArrayRectangle.Add(new Rectangle(363,162,482,270));
            p1 = pictureBox1.Location;
            p2 = pictureBox2.Location;
            p3 = pictureBox3.Location;
            p4 = PbGear1.Location;
            p5= PbGear2.Location;
            p6= PbGear3.Location;
        }

        private void Oclock_Load(object sender, EventArgs e)
        {
            label1.Text = sec.ToString();
             if (File.Exists("BonusSave.json")&&swicher)
            {
                using (StreamReader reader = File.OpenText("BonusSave.json"))
                {
                    var fileText = reader.ReadToEnd();
                    TimeBonus.SetBonus(JsonConvert.DeserializeObject<int>(fileText));
                }
                swicher = false;
                bonus = TimeBonus.PrintBonus();
                label2.Text = TimeBonus.PrintBonus().ToString();
            }
            Gear.GetBitmapsFromResourceFolder("Gear_");
            FonOclock.GetBitmapsFromResourceFolder("Fon_");
            pictureBox3.Location = p3;
            PbGear1.Location = p4;
            PbGear2.Location = p5;
            pictureBox2.Location = p2;
            pictureBox1.Location = p1;
            PbGear3.Location = p6;
            int k = 0;
            for (int i = 3; i < Controls.Count; i++)
            {
                if (Controls[i] is PictureBox)
                ((PictureBox)Controls[i]).Image = Gear.imageList[k];
                k++;
            }
            Random r = new Random();
            
                index = Convert.ToByte(r.Next(0, 4));
            this.BackgroundImage = FonOclock.imageList[index];
            this.BackgroundImageLayout = ImageLayout.Center;
            this.Size = new Size(FonOclock.imageList[index].Width, FonOclock.imageList[index].Height);
            this.Location= new Point(0,0);
            timer1.Start();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            
                if (IndexGear[index, 0] != Convert.ToInt32(((PictureBox)sender).Tag) &&
                IndexGear[index, 1] != Convert.ToInt32(((PictureBox)sender).Tag) &&
                IndexGear[index, 2] != Convert.ToInt32(((PictureBox)sender).Tag))
                {
                    ((PictureBox)sender).Location = startLocation;
                return;
                }
            
            for (int i = 0; i < 6; i++)
            {
                if (((PictureBox)sender).Tag.ToString() == i.ToString())
                {
                    if (((PictureBox)sender).Location.X >= ArrayRectangle[i].X &&
                        ((PictureBox)sender).Location.X <= ArrayRectangle[i].Width &&
                        ((PictureBox)sender).Location.Y >= ArrayRectangle[i].Y &&
                        ((PictureBox)sender).Location.Y <= ArrayRectangle[i].Height)
                    {
                        TimerCheck++;
                        MessageBox.Show(" Гарна робота!");
                    }
                    else ((PictureBox)sender).Location = startLocation;
                }
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = Cursor.Position;
            Console.WriteLine(startPoint.ToString());
            startLocation = ((PictureBox)sender).Location;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {

                ((PictureBox)sender).Left += Cursor.Position.X - startPoint.X;
                ((PictureBox)sender).Top += Cursor.Position.Y - startPoint.Y;
                Console.WriteLine("pb="+((PictureBox)sender).Location+ " cursor = "+Cursor.Position);
                startPoint = Cursor.Position;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = sec.ToString();
            sec--;
            if (TimeBonus.Time(sec))
            {
                timer1.Stop();
                bonus -= 15;
                label2.Text = bonus.ToString();
                button1.Enabled = true;
                MessageBox.Show("Ви програли");
            }
            if (TimerCheck == 3)
            {
                timer1.Stop();
                bonus += 15;
                button1.Enabled = true;
                label2.Text = bonus.ToString();
            }
        }

        private void Oclock_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimeBonus.SetBonus(bonus);
            using (StreamWriter writer = File.CreateText("BonusSave.json"))
            {
                string output = JsonConvert.SerializeObject(TimeBonus.PrintBonus());
                writer.Write(output);
            }
            timer1.Stop();
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oclock_Load(null, null);
            button1.Enabled = false;
            sec = 25;
            TimerCheck = 0;
            label1.Text = sec.ToString();
        }

        private void Oclock_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Cursor.Position.ToString();
        }
    }
}