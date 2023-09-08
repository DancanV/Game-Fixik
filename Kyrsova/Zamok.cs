using Kyrsova.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsova
{
    public partial class Zamok : Form
    {
        ZamokLevel2 Level2 = new ZamokLevel2(); 
        int i=0, j=0, k=0;
        GameControl Bonus = new GameControl();
        public Zamok()
        {
            InitializeComponent();
            pZamok.BackColor = Color.Transparent;
        }

        private void btUp3_Click(object sender, EventArgs e)
        {
                 i++;
            if (i > 9)
                i = 0;

            Lb1.Text = i.ToString();
                
        }

        private void btUp2_Click(object sender, EventArgs e)
        {
            j++;
            if (j > 9)
                j = 0;


            Lb2.Text = j.ToString();
        }

        private void btUp1_Click(object sender, EventArgs e)
        {
            k++;
            if (k > 9)
                k = 0;


            Lb3.Text = k.ToString();
        }

        private void btDown2_Click(object sender, EventArgs e)
        {
            j--;
            if (j < 0)
                j = 9;


            Lb2.Text = j.ToString();
        }

        private void btDown1_Click(object sender, EventArgs e)
        {
            k--;
            if (k < 0)
                k = 9;


            Lb3.Text = k.ToString();
        }

        private void btChek_Click(object sender, EventArgs e)
        {
            if (Level2.ChekPassword())
            {
                btChek.Enabled=false; 
                Refresh.Enabled = true;
                MessageBox.Show("Гарна робота!");
                Bonus.Sum(20);
                PrintBonus.Text = Bonus.PrintBonus().ToString();
            }
            else
            { 
                MessageBox.Show(" Не вірно  \n " +"Підказка - " + Level2.ReturnTruePassword());
                Bonus.Dif(15);
                PrintBonus.Text = Bonus.PrintBonus().ToString();
            }

        }

        private void Zamok_Load(object sender, EventArgs e)
        {
            PrintBonus.Text = "0";
            if (File.Exists("BonusSave.json"))
            {
                using (StreamReader reader = File.OpenText("BonusSave.json"))
                {
                    var fileText = reader.ReadToEnd();
                    Bonus.SetBonus(JsonConvert.DeserializeObject<int>(fileText));
                }
                PrintBonus.Text = Bonus.PrintBonus().ToString();
            }
        }

        private void Zamok_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Bonus != null)
            {
                using (StreamWriter writer = File.CreateText("BonusSave.json"))
                {
                    string output = JsonConvert.SerializeObject(Bonus.PrintBonus());
                    writer.Write(output);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            btChek.Enabled = true;
            Refresh.Enabled = false;
            Lb1.Text = "0";
            Lb2.Text = "0";
            Lb3.Text = "0";
            Level2.RandomPasword();
            i = j = k = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PrintBonus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb2_Click(object sender, EventArgs e)
        {

        }

        private void Lb3_TextChanged(object sender, EventArgs e)
        {
            Level2.getPassword(Lb1.Text + Lb2.Text + Lb3.Text);
        }

        private void btDown3_Click(object sender, EventArgs e)
        {
            i--;
            if (i<0)
            i=9;
            Lb1.Text = i.ToString();
        }
    }


}
