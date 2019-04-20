using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Black);
            pictureBox1.Image = bitmap;


            /*GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddEllipse(100, 100, 200, 200);
            gp.AddRectangle(new Rectangle(100, 100, 200, 350));
            //graphics.DrawPath(new Pen(color), gp);
            graphics.FillPath(new Pen(Color.Red, 3).Brush, gp);
            pictureBox1.Refresh();*/



        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Shar(35, 35, 30);
            Shar(95, 35, 30);
            Shar(150, 90, 30);
            Juldyz();

            void Shar(int x, int y, int d)
            {
                SolidBrush solidBrush = new SolidBrush(Color.White);
                e.Graphics.FillEllipse(solidBrush, x, y, d, d);
                pictureBox1.Refresh();
            }
            void Juldyz()
            {
                Point[] myPointArray = { new Point(25, 0), new Point(50, 50), new Point(0, 50) };
                graphics.DrawPolygon(new Pen(Color.Green), myPointArray);

                SolidBrush solidBrush = new SolidBrush(Color.Green);
                e.Graphics.FillPolygon(solidBrush, myPointArray);
            }
        }
    }
}
