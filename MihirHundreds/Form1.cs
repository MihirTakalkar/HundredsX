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

        List<Baller> balls;

        private void Form1_Load(object sender, EventArgs e)
        {
            balls = new List<Baller>();
            balls.Add(new Baller(20, 20, 40, 40, 3, 3));
            balls.Add(new Baller(30, 60, 40, 40, 5, 5));
            gfx = Graphics.FromImage();
        }

        private void MoTi_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Update(ClientSize);
                balls[i].Draw(gfx);
            }
        }
    }
}
