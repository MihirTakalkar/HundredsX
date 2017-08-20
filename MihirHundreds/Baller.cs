using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihirHundreds
{
    class Baller
    {
        int height;
        int width;
        int ballx;
        int bally;
        public int speedx;
        public int speedy;

        public Baller(int ballx, int bally, int width, int height, int speedx, int speedy)
        {
            this.ballx = ballx;
            this.bally = bally;
            this.width = width;
            this.height = height;
            this.speedx = speedx;
            this.speedy = speedy;
        }

        public void Update(Size ClientSize)
        {
            if (bally + height > ClientSize.Height)
            {
                speedy *= -1;
            }
            if(ballx + width > ClientSize.Width)
            {
                speedx *= -1;
            }
            if (bally < 0)
            {
                speedy *= -1;
            }
            if(ballx < 0)
            {
                speedx *= -1;
            }

            ballx += speedx;
            bally += speedy;
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(Brushes.DarkGray, ballx, bally, width, height);
            gfx.DrawRectangle(Pens.Red, ballx, bally, width, height);
        }

    }
}
