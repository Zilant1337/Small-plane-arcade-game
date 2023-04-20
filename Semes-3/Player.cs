using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Semes_3
{
    class Player
    {
        public float x;
        public float y;

        public int score;
        public int size;

        public Image sprite;

        public bool isNotHit;

        public Player(int x, int y)
        {
            sprite = new Bitmap("Plane.png");
            size = 32;
            isNotHit = true;
            score = 0;
            this.x = x;
            this.y = y;
        }
    }
}
