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
    public partial class Form1 : Form
    {
        GameControl gameControl;

        public Form1()
        {
            InitializeComponent();
            gameControl = new GameControl();
        }

        void SetScore(Form form)
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText("BonusSave.json"))
                {
                    var fileText = reader.ReadToEnd();
                    gameControl.SetBonus(JsonConvert.DeserializeObject<int>(fileText));
                }

                textBox1.Text = gameControl.PrintBonus().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamok z = new Zamok();
            SetScore(z);
        }

        private void btLevel3_Click(object sender, EventArgs e)
        {
            Oclock o = new Oclock();
            SetScore(o);
        }

        private void btPomogator1_Click(object sender, EventArgs e)
        {
            Pomagator p = new Pomagator();
            SetScore(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("BonusSave.json"))
                using (StreamReader reader = File.OpenText("BonusSave.json"))
                {
                    var fileText = reader.ReadToEnd();
                    gameControl.SetBonus(JsonConvert.DeserializeObject<int>(fileText));
                }

            textBox1.Text = gameControl.PrintBonus().ToString();
        }
    }
}
