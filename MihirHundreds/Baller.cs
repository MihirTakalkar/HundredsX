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
        int ogHeight;
        int ogWidth;
        int ballx;
        int bally;
        public int speedx;
        public int speedy;

        public float scale = 1;

        public int X
        {
            get
            {
                return ballx;
            }
            set
            {
                ballx = value;
            }
        }

        public int Width
        {
            get
            {
                return (int)(ogWidth * scale);
            }
        }

        public int Height
        {
            get
            {
                return (int)(ogHeight * scale);
            }
        }

  

        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle(ballx, bally, Width, Height);
            }
        }

        public Baller(int ballx, int bally, int width, int height, int speedx, int speedy)
        {
            this.ballx = ballx;
            this.bally = bally;
            this.ogWidth = width;
            this.ogHeight = height;
            this.speedx = speedx;
            this.speedy = speedy;


        }

        public void Update(Size ClientSize)
        {


            if (bally + Height > ClientSize.Height)
            {
                speedy = -Math.Abs(speedy);
            }
            if (ballx + Width > ClientSize.Width)
            {
                speedx = -Math.Abs(speedx);
            }
            if (bally < 0)
            {
                speedy = Math.Abs(speedy);
            }
            if (ballx < 0)
            {
                speedx = Math.Abs(speedx);
            }

            ballx += speedx;
            bally += speedy;
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(Brushes.DarkGray, ballx, bally, Width, Height);
            gfx.DrawRectangle(Pens.Red, Hitbox);
        }

    }
}
