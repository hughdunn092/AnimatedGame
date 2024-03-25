using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedGame
{
    internal class Player
    {
        public int x, y;
        public int width = 10;
        public int height = 10;
        public int speed = 6;

        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(string direction)
        {
            if (direction == "up")
            {
                y -= speed;

                if (y < 0)
                {
                    y = 0;
                }

            }
            else if (direction == "down")
            {
                y += speed;

                if (y > GameScreen.height - height)
                {
                    x = GameScreen.height - height;
                }
            }
            else if (direction == "left")
            {
                x -= speed;

                if (x < 0)
                {
                    x = 0;
                }
            }
            else
            {
                x += speed;

                if (x < GameScreen.width - width)
                {
                    x = GameScreen.width - width;
                }
            }
        }

        //public bool Collision(Ball ball)
        //{
        //    Rectangle playerRec = new Rectangle(x, y, width, height);
        //    Rectangle ballRec = new Rectangle(ball.x, ball.y, ball.size, ball.size);

        //    if (playerRec.IntersectsWith(ballRec))
        //    {
        //        //move the ball to the front of the player
        //        if (ball.ySpeed > 0)
        //        {
        //            ball.y = y - ball.size;
        //        }
        //        else
        //        {
        //            ball.y = y + height;
        //        }
        //        //change the ball's direction
        //        ball.ySpeed *= -1;

        //        return true;
        //    }

        //    return false;
        //}
    }
}
