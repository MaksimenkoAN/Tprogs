using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen violet_pen = new Pen(Color.Violet, 5);
            IPoint a = new Point(0, 100);
            IPoint b = new Point(100, 0);
            IDrawable nline = new VisualLine(a, b);
            nline.Draw(violet_pen, sender, e, 0.01);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Pen black_pen = new Pen(Color.Black, 5);
            IPoint a = new Point(0, 100);
            IPoint b = new Point(100, 0);
            IPoint c = new Point(17, 67);
            IPoint d = new Point(92, 67);
            IDrawable nbezier = new VisualBezier(a, b, c, d);
            nbezier.Draw(black_pen, sender, e, 0.01);
        }
    }
}