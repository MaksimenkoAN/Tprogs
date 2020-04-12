using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class VisualLine: AVisualCurve
    {
        private IPoint a, b;
        public VisualLine(IPoint _a, IPoint _b)
        {
            a = _a;
            b = _b;
        }
        override public IPoint GetPoint(double t, out IPoint p)
        {
            ICurve _line = new Line(a, b);
            _line.GetPoint(t, out IPoint lp);
            p = lp;
            return p;
        }
        override public void Draw(Pen _pen, object sender, PaintEventArgs e, double t)
        {
            ICurve _line = new Line(a, b);
            IPoint sp = a;
            float spxf = Convert.ToSingle(sp.getX()), spyf = Convert.ToSingle(sp.getY()), fpxf, fpyf;
            for (double i = t; i <=1; i += t)
            {
                _line.GetPoint(i,out IPoint fp);
                fpxf = Convert.ToSingle(fp.getX());
                fpyf = Convert.ToSingle(fp.getY());
                e.Graphics.DrawLine(_pen, new PointF(spxf, spyf), new PointF(fpxf, fpyf));
                spxf = fpxf;
                spyf = fpyf;
            }
        }
    }
}
