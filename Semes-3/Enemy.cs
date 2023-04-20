using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Semes_3
{
    class Enemy
    {
        public float x;
        public float y;

        public int size;
        public char movingSide;

        public Image sprite;

        public bool isNotHit;

        public Enemy(int x, int y)
        {
            this.x = x;
            this.y = y;
            sprite = new Bitmap("Enemy.png");
            movingSide = 'r';
            size = 32;
            isNotHit = true;
        }
    }
}
