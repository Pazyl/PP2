using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        int d = 10;
        //int w = 10;
        //int h = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            d += 5;
            //w += 5;
            //h += 5;
            toolStripStatusLabel1.Text = string.Format("[W = {0}, H = {1}]", d, d);
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Red, 2), new Rectangle(250 - d, 125 - d, 50 + 2 * d, 50 + 2 * d));
        }
    }
}
