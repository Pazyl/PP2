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

namespace TASK3
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Point prevPoint;
        Point currentPoint;
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Blue);
            pictureBox1.Image = bitmap;

            /*SolidBrush solidBrush = new SolidBrush(Color.White);
            Point[] myPointArray = { new Point(0, 50), new Point(25, 7), new Point(50, 50) };
            graphics.FillPolygon(solidBrush, myPointArray);

            SolidBrush solidBrush1 = new SolidBrush(Color.White);
            Point[] myPointArray1 = { new Point(0, 25), new Point(50, 25), new Point(25, 63) };
            graphics.FillPolygon(solidBrush1, myPointArray1);

            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddPolygon(myPointArray);
            gp.AddPolygon(myPointArray1);
            graphics.FillPath(new Pen(Color.Red).Brush, gp);*/

            asteroid(108, 40);
            asteroid(139, 210);
            asteroid(389, 250);
            asteroid(464, 78);
            spaceship(291, 127);
            gun(291, 127);

        }
        public void asteroid(int X, int Y)
        {
            Point[] myPointArray1 = { new Point(X, Y+50), new Point(X+25, Y+7), new Point(X+50, Y+50) };
            Point[] myPointArray2 = { new Point(X, Y+25), new Point(X+50, Y+25), new Point(X+25, Y+63) };

            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddPolygon(myPointArray1);
            gp.AddPolygon(myPointArray2);

            graphics.FillPath(new Pen(Color.Red).Brush, gp);
        }


        public void spaceship(int X, int Y)
        {
            Point[] myPointArray1 = { new Point(X, Y + 30), new Point(X, Y + 80), new Point(X + 50, Y + 110),
                                      new Point(X+100, Y + 80), new Point(X + 100, Y + 30), new Point(X + 50, Y) };

            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddPolygon(myPointArray1);

            graphics.FillPath(new Pen(Color.Yellow).Brush, gp);
        }


        public void gun(int X, int Y)
        {
            Point[] myPointArray1 = { new Point(X + 40, Y + 45), new Point(X + 60, Y + 45), new Point(X + 60, Y + 85), new Point(X + 40, Y + 85) };
            Point[] myPointArray2 = { new Point(X + 35, Y + 45), new Point(X + 65, Y + 45), new Point(X + 50, Y + 15) };

            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddPolygon(myPointArray1);
            gp.AddPolygon(myPointArray2);

            graphics.FillPath(new Pen(Color.Green).Brush, gp);
        }





        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentPoint = e.Location;

                //graphics.DrawLine(new Pen(Color.Red), e.X, e.Y, 50, 50);
                //pictureBox1.Refresh();
                prevPoint = currentPoint;

                toolStripStatusLabel1.Text = string.Format("X = {0}, Y = {1}", e.X, e.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.White);
            graphics.FillEllipse(solidBrush, e.X-30, e.Y-30, 50, 50);
            pictureBox1.Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
