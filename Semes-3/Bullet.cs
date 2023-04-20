using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Semes_3
{
    class Bullet
    {
        public float x;
        public float y;

        public int score;
        public int size;

        public Image sprite;

        public bool present;

        public Bullet(float x, float y,bool pres)
        {
            sprite = new Bitmap("Bullet.png");
            size = 32;
            present = pres;
            score = 0;
            this.x = x;
            this.y = y;
        }
    }
}
