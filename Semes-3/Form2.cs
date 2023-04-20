using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Semes_3
{
    public partial class Form2 : Form
    {
        private Image bombSprite = Image.FromFile(Directory.GetCurrentDirectory() + "\\bomb.png");
        
        public int enmCnt = 1;

        
        public int bombTick = 0;
        Form1 parent;
        public Form2(Form1 f)
        {
            parent = f;

            InitializeComponent();
            
            timerBomb.Start();
            pictureBoxBomb.Image = bombSprite;
            timerAnimation.Start();
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            enmCnt = comboBox1.SelectedIndex+1;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            parent.changeEnemyCount(enmCnt);
            
            this.Close();
        }

        private void timerBomb_Tick(object sender, EventArgs e)
        {
            bombTick++;
            pictureBoxBomb.Location = new Point(pictureBoxBomb.Location.X, pictureBoxBomb.Location.Y + (int)displacement(bombTick));
            if (bombTick >= 100)
            {
                timerBomb.Stop();
            }
        }
        private double displacement(double t)
        {
            return t - (1 / 2) * 9.8 * Math.Pow(t, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 toon = new Form3();
            toon.Show();
        }
    }
}
