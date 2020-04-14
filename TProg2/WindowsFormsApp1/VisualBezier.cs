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
        public VisualBezier(AImplementor _imp, IPoint _a, IPoint _b, IPoint _c, IPoint _d):base(_imp)
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
        override public void Draw( int n, Graphics g)
        {
            ICurve _bezier = new Bezier(a, b, c, d);
            IPoint sp = a;
            double t = 0;
            float spxf = Convert.ToSingle(sp.getX()), spyf = Convert.ToSingle(sp.getY()), fpxf = 0, fpyf = 0;
            imp.DrawStartPoint(new PointF(spxf, spyf), g);
            for (int i = 1; i <= n; i++)
            {
                t += 1.0 / n;
                _bezier.GetPoint(t, out IPoint fp);
                fpxf = Convert.ToSingle(fp.getX());
                fpyf = Convert.ToSingle(fp.getY());
                imp.DrawLine(new PointF(spxf,spyf), new PointF(fpxf, fpyf), g);
                if (i != n)
                {
                    spxf = fpxf;
                    spyf = fpyf;
                }
            }
            imp.DrawFinishPoint(new PointF(spxf, spyf), new PointF(fpxf, fpyf), g);
        }
    }
}
