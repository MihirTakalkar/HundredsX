using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihirHundreds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gfx;
        Random rand = new Random();
        List<Baller> balls;
        Bitmap bitmap;
        Point mouse = new Point(0, 0);
        Font font;

        private void Form1_Load(object sender, EventArgs e)
        {
            font = label1.Font;

            balls = new List<Baller>();
            balls.Add(new Baller(20, 20, 40, 40, 2, 2));
            balls.Add(new Baller(120, 60, 40, 40, 4, 4));
            balls.Add(new Baller(220, 70, 40, 40, 6, 6));
            balls.Add(new Baller(320, 90, 40, 40, 7, 7));
            balls.Add(new Baller(420, 10, 40, 40, 8, 8));
            bitmap = new Bitmap(BacIm.Width, BacIm.Height);
            gfx = Graphics.FromImage(bitmap);


        }

        private void MoTi_Tick(object sender, EventArgs e)
        {
            //erase
            gfx.DrawImage(BackgroundImage, 0, 0, ClientSize.Width, ClientSize.Height);

            int totalScore = 0;

            for (int i = 0; i < balls.Count; i++)
            {
                bool growing = false;
                balls[i].Update(ClientSize);
                if (balls[i].Contains(mouse))
                {
                    balls[i].scale += 0.05f;
                    growing = true;
                    //score++
                }

                totalScore += balls[i].score;

                for (int f = i + 1; f < balls.Count; f++)
                {
                    //calculate intersection
                    if (balls[i].Intersects(balls[f]))
                    {
                        balls[i].speedx *= -1;
                        balls[i].speedy *= -1;
                        balls[f].speedx *= -1;
                        balls[f].speedy *= -1;

                        if (growing == true)
                        {
                            MoTi.Stop();
                            MessageBox.Show("You Lose! Fooool!");
                        }
                    }
                }

                //if the balls' hitbox contains our mouse point, increase scale

            }

            if (totalScore >= 100)
            {
                MoTi.Stop();
                MessageBox.Show("You Win! Idioooot!");
            }

            //draw the score 
            string message = "Hello World";
            SizeF size = gfx.MeasureString(message, font);
            gfx.DrawString(message, font, Brushes.Blue, ClientSize.Width / 2 - size.Width/2, ClientSize.Height / 2 - size.Height/2);

            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Draw(gfx);
            }



            BacIm.Image = bitmap;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                int randomNumber = rand.Next(0, 150);
                balls.Add(new Baller(randomNumber, randomNumber, 50, 50, 6, 6));
            }
        }

        private void BacIm_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = new Point(e.X, e.Y);
            this.Text = $"X:{mouse.X}, Y:{mouse.Y}";
        }
    }
}
