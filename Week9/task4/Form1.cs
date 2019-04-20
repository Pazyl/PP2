using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    
    public partial class Form1 : Form
    {
        Boolean LeftMove, UpMove;
        Graphics graphics;
        Point prevPoint;
        Point currentPoint;
        int d = 100;
        int b = 125;
        int velocity = 8;
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Blue);
            pictureBox1.Image = bitmap;
            //graphics.DrawEllipse(new Pen(Color.Red, 2), new Rectangle(250 + d, 125, 50, 50));
            pictureBox1.Refresh();
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            d = d + velocity;
            b = b + velocity;

            if (d <= 0)
            {
                velocity = -velocity;
            }
            if (d + 50 >= pictureBox1.Width)
            {
                velocity = -velocity;
            }
            

            if (b <= 0)
            {
                velocity = -velocity;
            }
            if (b + 50 >= pictureBox1.Height)
            {
                velocity = -velocity;
            }

            Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Red, 2), new Rectangle(d, b, 50, 50));
        }

        /*if (keyboardState.IskeyDown(Keys.Up))
            Position.Y -= 4;*/
    }
}
