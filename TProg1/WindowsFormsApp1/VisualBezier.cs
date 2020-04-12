using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class VisualBezier: AVisualCurve
    {
        private IPoint a, b, c, d;
        public VisualBezier(IPoint _a, IPoint _b, IPoint _c, IPoint _d)
        {
            a = _a;
            b = _b;
            c = _c;
            d = _d;
        }
        override public IPoint GetPoint(double t, out IPoint p)
        {
            ICurve _bezier = new Bezier(a, b, c, d);
            _bezier.GetPoint(t, out IPoint lp);
            p = lp;
            return p;
        }
        override public void Draw(Pen _pen, object sender, PaintEventArgs e, double t)
        {
            ICurve _bezier = new Bezier(a, b, c, d);
            IPoint sp = a;
            float spxf = Convert.ToSingle(sp.getX()), spyf = Convert.ToSingle(sp.getY()), fpxf, fpyf;
            for (double i = t; i <= 1; i += t)
            {
                _bezier.GetPoint(i, out IPoint fp);
                fpxf = Convert.ToSingle(fp.getX());
                fpyf = Convert.ToSingle(fp.getY());
                e.Graphics.DrawLine(_pen, new PointF(spxf, spyf), new PointF(fpxf, fpyf));
                spxf = fpxf;
                spyf = fpyf;
            }
        }
    }
}
