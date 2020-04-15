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
        public VisualBezier(IImplementor _imp, int n, IPoint _a, IPoint _b, IPoint _c, IPoint _d):base(_imp, n)
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
        override public void Draw()
        {
            ICurve _bezier = new Bezier(a, b, c, d);
            IPoint sp = a;
            double t = 0;
            _bezier.GetPoint((1.0 / n), out IPoint fp);

            float spxf = Convert.ToSingle(sp.getX()), spyf = Convert.ToSingle(sp.getY()), fpxf, fpyf;
            fpxf = Convert.ToSingle(fp.getX());
            fpyf = Convert.ToSingle(fp.getY());
            DrawStartPoint(new PointF(spxf, spyf), new PointF(fpxf, fpyf));
            for (int i = 1; i < n; i++)
            {
                t += 1.0 / n;
                _bezier.GetPoint(t, out IPoint fp1);
                fpxf = Convert.ToSingle(fp1.getX());
                fpyf = Convert.ToSingle(fp1.getY());
                DrawLine(new PointF(spxf,spyf), new PointF(fpxf, fpyf));
                if (i != n)
                {
                    spxf = fpxf;
                    spyf = fpyf;
                }
            }
            _bezier.GetPoint(1, out IPoint fpf);
            fpxf = Convert.ToSingle(fpf.getX());
            fpyf = Convert.ToSingle(fpf.getY());
            DrawFinishPoint(new PointF(spxf, spyf), new PointF(fpxf, fpyf));
        }
    }
}
