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
        Point mouse = new Point(0, 0);

        public float scale = 1;

        public int score = 0;

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

        public int Y
        {
            get
            {
                return bally;
            }
            set
            {
                bally = value;
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

        public int CenterX
        {
            get
            {
                return (X + Radius);
            }
        }

        public int CenterY
        {
            get
            {
                return (Y + Radius);
            }
        }

        public int Radius
        {
            get
            {
                return (Width / 2);
            }
        }

        //public Rectangle Hitbox
        //{
        //    get
        //    {
        //        return new Rectangle(ballx, bally, Width, Height);
        //    }
        //}

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
            //gfx.DrawRectangle(Pens.BlueViolet, Hitbox);
            Point scoreCoord = new Point(ballx + 10, bally);
            gfx.DrawString(score.ToString(), new Font("Ariel", 14), new SolidBrush(Color.Black), scoreCoord);
        }

        public bool Intersects(Baller other)
        {
            //if one ball intersects with the other ball
            int sum = Radius + other.Radius;
            double distance = Math.Sqrt(Math.Pow(other.CenterX - CenterX, 2) + Math.Pow(other.CenterY - CenterY, 2));
            if(sum > distance)
            {
                return true;
            }

            return false;
        }

        public bool Contains(Point point)
        {
            //if the point is inside of the ball
            double distance = Math.Sqrt(Math.Pow(point.X - CenterX, 2) + Math.Pow(point.Y - CenterY, 2));
            if (Radius > distance)
            {
                score++;
                return true;
            }

            return false;
        }

    }
}
