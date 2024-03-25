using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedGame
{
    internal class UpBall
    {
        public int size, speed, y;

        public UpBall(int size, int speed, int y)
        {
            this.y = y;
            this.size = size;
            this.speed = speed;

            size = 10;
        }
        public void Move()
        {
            y += speed;

            if (y < 0 || y > GameScreen.height - size)
            {
                speed *= -1;
            }
        }
    }
}

