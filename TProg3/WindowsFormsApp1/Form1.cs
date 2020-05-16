using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        IPoint a = new Point(10, 100);
        IPoint b = new Point(100, 10);
        IPoint c = new Point(17, 67);
        IPoint d = new Point(92, 67);
        IPoint sa = new Point(20, 100);
        IPoint sb = new Point(100, 100);
        IPoint sc = new Point(55, 67);
        IPoint sd = new Point(132, 67);
        IPoint fragmove = new Point(50, 100);

        int n1 = 10;
        int n2 = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = new System.Drawing.Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.Clear(Color.White);
            Graphics g2 = Graphics.FromImage(pictureBox2.Image);
            g2.Clear(Color.White);
            IImplementor imp1 = new ConcreteImp1(g1);
            IImplementor imp2 = new ConcreteImp2(g2);
            IDrawable ac = new VisualLine(imp1, n1, a, b);
            ac.Draw();
            IDrawable ac1 = new VisualBezier(imp2, n2, a, b, c ,d);
            ac1.Draw();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png|" +
                "SVG File(*.txt)|*.txt|";
            savedialog.ShowHelp = true;
            // If selected, save
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                // Get the user-selected file name
                string fileName = savedialog.FileName;
                // Get the extension
                string strFilExtn =
                    fileName.Remove(0, fileName.Length - 3);
                // Save file
                switch (strFilExtn)
                {
                    case "bmp":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png|";
            savedialog.ShowHelp = true;
            // If selected, save
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                // Get the user-selected file name
                string fileName = savedialog.FileName;
                // Get the extension
                string strFilExtn =
                    fileName.Remove(0, fileName.Length - 3);
                // Save file
                switch (strFilExtn)
                {
                    case "bmp":
                        pictureBox2.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        pictureBox2.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        pictureBox2.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        pictureBox2.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        pictureBox2.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = new System.Drawing.Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.Clear(Color.White);
            Graphics g2 = Graphics.FromImage(pictureBox2.Image);
            g2.Clear(Color.White);
            IImplementor imp1 = new ConcreteImp1(g1);
            IImplementor imp2 = new ConcreteImp2(g2);
            IPoint swap;
            swap = a;
            a = b;
            b = swap;
            swap = c;
            c = d;
            d = swap;
            IDrawable ac = new VisualLine(imp1, n1, a, b);
            ac.Draw();
            IDrawable ac1 = new VisualBezier(imp2, n2, a, b, c, d);
            ac1.Draw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = new System.Drawing.Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.Clear(Color.White);
            Graphics g2 = Graphics.FromImage(pictureBox2.Image);
            g2.Clear(Color.White);
            ICurve frag1 = new Fragment(new Line(a, b), 0.0, 0.5);
            MoveTo curvemv = new MoveTo(frag1, fragmove, 0.0);
            IPoint newa = curvemv.GetPoint(0.0, out IPoint pa);
            IPoint newb = curvemv.GetPoint(1.0, out IPoint pb);
            double valx;
            double valy;
            IPoint newc;
            IPoint newd;
            IImplementor imp1 = new ConcreteImp1(g1);
            IImplementor imp2 = new ConcreteImp2(g2);
            IDrawable ac;
            IPoint check = frag1.GetPoint(0.0, out IPoint pfaa);
            
            if ((a.getX() != check.getX()) && (a.getY() != check.getY()))
            {
                ac = new VisualLine(imp1, n1/2, a, frag1.GetPoint(0.0, out IPoint pfa));
                ac.Draw();

            }
            ac = new VisualLine(imp1, n1/2, newa, newb);
            ac.Draw();
            check = frag1.GetPoint(1.0, out IPoint pfbb);
            if ((b.getX() != check.getX()) && (b.getY() != check.getY()))
            {
                ac = new VisualLine(imp1, n1/2, frag1.GetPoint(1.0, out IPoint pfb), b);
                ac.Draw();
            }
            frag1 = new Fragment(new Bezier(a, b, c, d), 0.0, 0.5);
            curvemv = new MoveTo(frag1, fragmove, 0.0);
            newa = curvemv.GetPoint(0.0, out IPoint pab);
            newb = curvemv.GetPoint(1.0, out IPoint pbb);
            valx = curvemv.GetX();
            valy = curvemv.GetY();
            newc = new Point(c.getX() + valx, c.getY() + valy);
            newd = new Point(d.getX() + valx, d.getY() + valy);

            check = frag1.GetPoint(0.0, out IPoint pfaab);

            if ((a.getX() != check.getX()) && (a.getY() != check.getY()))
            {
                ac = new VisualBezier(imp2, n1 / 2, a, frag1.GetPoint(0.0, out IPoint pfa), c, d);
                ac.Draw();

            }
            ac = new VisualBezier(imp2, n1 / 2, newa, newb, newc, newd);
            ac.Draw();
            check = frag1.GetPoint(1.0, out IPoint pfbbb);
            if ((b.getX() != check.getX()) && (b.getY() != check.getY()))
            {
                ac = new VisualBezier(imp2, n1 / 2, frag1.GetPoint(1.0, out IPoint pfb), b, c, d);
                ac.Draw();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = new System.Drawing.Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.Clear(Color.White);
            Graphics g2 = Graphics.FromImage(pictureBox2.Image);
            g2.Clear(Color.White);
            ICurve frag_line_1 = new Fragment(new Line(a, b), 0.0, 0.5);
            MoveTo curvemv = new MoveTo(frag_line_1, fragmove, 0.0);
            IPoint newa = curvemv.GetPoint(0.0, out IPoint pal);
            IPoint newb = curvemv.GetPoint(1.0, out IPoint pbl);
            IImplementor imp1 = new ConcreteImp1(g1);
            IImplementor imp2 = new ConcreteImp2(g2);
            IDrawable ac;
            IDrawable ac1;
            ac = new VisualLine(imp1, n1 / 2, newa, newb);
            ac.Draw();
            ICurve frag_line_2 = new Fragment(new Line(a, b), 0.5, 1.0);
            curvemv = new MoveTo(frag_line_2, newb, 0);
            newa = curvemv.GetPoint(0.0, out IPoint pa1l);
            newb = curvemv.GetPoint(1.0, out IPoint pb1l);
            ac = new VisualLine(imp1, n1 / 2, newa, newb);
            ac.Draw();

            ICurve frag_bezier_1 = new Fragment(new Bezier(a, b, c, d), 0.0, 0.5);
            curvemv = new MoveTo(frag_bezier_1, fragmove, 0.0);
            newa = curvemv.GetPoint(0.0, out IPoint pab);
            newb = curvemv.GetPoint(1.0, out IPoint pbb);
            double valx = curvemv.GetX();
            double valy = curvemv.GetY();
            IPoint newc = new Point(c.getX() + valx, c.getY() + valy);
            IPoint newd = new Point(d.getX() + valx, d.getY() + valy);
            ac = new VisualBezier(imp2, n1 / 2, newa, newb, newc, newd);
            ac.Draw();
            ICurve frag_bezier_2 = new Fragment(new Bezier(a, b, c, d), 0.5, 1.0);
            curvemv = new MoveTo(frag_bezier_2, newb, 0);
            newa = curvemv.GetPoint(0.0, out IPoint pa1b);
            newb = curvemv.GetPoint(1.0, out IPoint pb1b);
            valx = curvemv.GetX();
            valy = curvemv.GetY();
            newc = new Point(c.getX() + valx, c.getY() + valy);
            newd = new Point(d.getX() + valx, d.getY() + valy);
            ac = new VisualBezier(imp2, n1 / 2, newa, newb, newc, newd);
            ac.Draw();
        }
    }
}