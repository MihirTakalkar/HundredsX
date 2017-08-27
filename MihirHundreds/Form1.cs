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

        private void Form1_Load(object sender, EventArgs e)
        {
            balls = new List<Baller>();
            balls.Add(new Baller(20, 20, 40, 40, 3, 3));
            balls.Add(new Baller(30, 60, 40, 40, 5, 5));
            balls.Add(new Baller(70, 70, 40, 40, 7, 7));
            balls.Add(new Baller(90, 90, 40, 40, 8, 8));
            balls.Add(new Baller(10, 10, 40, 40, 10, 10));
            bitmap = new Bitmap(BacIm.Width, BacIm.Height);
            gfx = Graphics.FromImage(bitmap);


        }

        private void MoTi_Tick(object sender, EventArgs e)
        {
            //erase
            gfx.DrawImage(BackgroundImage, 0, 0, ClientSize.Width, ClientSize.Height);

            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Update(ClientSize);
                balls[i].Draw(gfx);
            }

            BacIm.Image = bitmap;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                int randomNumber = rand.Next(0, 150);
                balls.Add(new Baller(randomNumber, randomNumber, 50, 50, 6, 6));
            }
        }
    }
}
