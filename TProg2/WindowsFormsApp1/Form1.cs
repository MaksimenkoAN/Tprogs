using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        Bitmap bm1;
        public Form1()
        {
            InitializeComponent();
            bm1 = new Bitmap(panel1.Width, panel1.Height);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPoint a = new Point(10, 100);
            IPoint b = new Point(100, 10);
            IPoint c = new Point(17, 67);
            IPoint d = new Point(92, 67);
            var g1 = panel1.CreateGraphics();
            var g2 = panel2.CreateGraphics();
            AVisualCurve ac = new VisualLine(new ConcreteImp2(g1), a, b);
            panel1.DrawToBitmap(bm1, new Rectangle(0, 0, bm1.Width, bm1.Height));
            ac.Draw(8);
            AVisualCurve ac1 = new VisualBezier(new ConcreteImp1(g2), a, b, c ,d);
            ac1.Draw(8);
            g1.Save();
            g2.Save();
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));

            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bm.Save(sfd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}