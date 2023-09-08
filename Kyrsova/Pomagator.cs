using Kyrsova.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsova
{
    public partial class Pomagator : Form
    {
        FlyWeightImage First = new FlyWeightImage(10);
        FlyWeightImage Second = new FlyWeightImage(10);
        private GameControl gameControl;
        private int TagFirst = -1;
        private int TagSecond = -1;
        private object laskClickPBFirst;
        private object laskClickPBSecond;
        private int CheckPara;
        private int Score;
        int TimerCheck = 0;
        bool swicher = true;
        int sec = 19;

        public Pomagator()
        {
            InitializeComponent();
            gameControl = new GameControl();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is PictureBox)
                {
                    Controls[i].BackColor = Color.Transparent;
                }
            }
            button1.Enabled = false;
            LBTimer.Text = (sec+1).ToString();
        }

        private void Pomagator_Load(object sender, EventArgs e)
        {
            if (File.Exists("BonusSave.json")&&swicher)
            {
                using (StreamReader reader = File.OpenText("BonusSave.json"))
                {
                    var fileText = reader.ReadToEnd();
                    gameControl.SetBonus(JsonConvert.DeserializeObject<int>(fileText));
                }
                swicher = false;
                textBox1.Text = gameControl.PrintBonus().ToString();
            }

            First.GetBitmapsFromResourceFolder("First_");
            Second.GetBitmapsFromResourceFolder("Secondly_");
            List<byte> index = new List<byte>(5);
            Random r = new Random();
            int j = 0;
            int k = 0;
            byte n;
            while (true)
            {
                n = Convert.ToByte(r.Next(0, 10));
                if (!index.Contains(n))
                {
                    index.Add(n);
                    k++;
                }

                if (k == 5)
                    break;
            }

            k = 0;
            for (int i = 0; i < Controls.Count; i++)
            {

                if (Controls[i].AccessibleName == "1")
                {
                    ((PictureBox)Controls[i]).Image = First.imageList[index[j]];
                    j++;
                }
                else if (Controls[i].AccessibleName == "2")
                {
                    ((PictureBox)Controls[i]).Image = Second.imageList[index[k]];
                    k++;
                }
            }
            if(swicher)
                {
                Score = gameControl.PrintBonus();
                textBox1.Text = Score.ToString();
              }
            else
            {
                Score = int.Parse(textBox1.Text);
                gameControl.SetBonus(Score);

            }

            this.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Enabled=true;
            timer1.Start();
        }

        private void PbFirst_1_Click(object sender, EventArgs e)
        {
            TagFirst = First.Index(((PictureBox)sender).Image);
            if (sender == laskClickPBFirst)
            {
                ((PictureBox)sender).BackColor = Color.Red;
            }
            else
            {
                if (laskClickPBFirst != null)
                {
                    ((PictureBox)laskClickPBFirst).BackColor = Color.Transparent;
                }

                ((PictureBox)sender).BackColor = Color.Red;
                laskClickPBFirst = (PictureBox)sender;
            }

            if (ValidatePara())
            {
                ((PictureBox)laskClickPBFirst).Visible = false;
                ((PictureBox)laskClickPBSecond).Visible = false;
                CheckPara++;
                TimerCheck++;
                if (Check(CheckPara)) MessageBox.Show("Гарна робота!");
            }
        }

        private void PbSecondly_4_Click(object sender, EventArgs e)
        {
            TagSecond = Second.Index(((PictureBox)sender).Image);
            if (sender == laskClickPBSecond)
            {
                ((PictureBox)sender).BackColor = Color.Red;
            }
            else
            {
                if (laskClickPBSecond != null)
                {
                    ((PictureBox)laskClickPBSecond).BackColor = Color.Transparent;
                }

                ((PictureBox)sender).BackColor = Color.Red;
                laskClickPBSecond = (PictureBox)sender;
            }

            if (ValidatePara())
            {
                ((PictureBox)laskClickPBFirst).Visible = false;
                ((PictureBox)laskClickPBSecond).Visible = false;
                CheckPara++;
                TimerCheck++;
                if (Check(CheckPara))
                {
                    MessageBox.Show("Гарна робота!");
                }
            }
        }

        bool ValidatePara()
        {
            if (TagFirst == TagSecond)
            {
                return true;
            }

            return false;
        }

        bool Check(int index)
        {
            if (index == 5)
            {
                Score += 40;
                button1.Enabled = true;
                textBox1.Text = Score.ToString();
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pomagator_Load(null, null);
            CheckPara = 0;
            button1.Enabled = false;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is PictureBox)
                {
                    Controls[i].Visible = true;
                    Controls[i].BackColor = Color.Transparent;
                }
            }

            sec = 19;
            TimerCheck = 0;
            LBTimer.Text = sec.ToString();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Pomagator_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameControl.SetBonus(Score);
            using (StreamWriter writer = File.CreateText("BonusSave.json"))
            {
                string output = JsonConvert.SerializeObject(gameControl.PrintBonus());
                writer.Write(output);
            }
            timer1.Stop();
            timer1.Enabled = false;
            DialogResult = DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBTimer.Text = sec.ToString();
            sec--;
            if (gameControl.Time(sec))
            {
                timer1.Stop();
                Score -= 15;
                textBox1.Text = Score.ToString();
                button1.Enabled = true;
                MessageBox.Show("Ви програли");
            }
            if (TimerCheck == 5)
            {
                timer1.Stop();
                button1.Enabled = true;
                textBox1.Text = Score.ToString();
            }
        }
    }
}
 