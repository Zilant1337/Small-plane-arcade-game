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
    public partial class Form3 : Form
    {
        private int animFrames = 0;
        private List<Image> MSFrames = new List<Image>(); public int animFrame = 0;
        public Form3()
        {
            InitializeComponent();
            for (int i = 0; i < 38; i++)
            {
                MSFrames.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\NakedGunMS\\" + i.ToString() + ".png"));
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timerAnimation.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            
                if (animFrame >= 38)
                {
                    animFrame = 0;
                }
                pictureBox1.Image = MSFrames[animFrame];
            animFrame++;
            
        }
    }
}
