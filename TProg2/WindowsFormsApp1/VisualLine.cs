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
        public VisualLine(IImplementor _imp, int n, IPoint _a, IPoint _b):base(_imp, n)
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
        override public void Draw()
        {
            ICurve _line = new Line(a, b);
            IPoint sp = a;
            double t = 0;
            _line.GetPoint((1.0 / n), out IPoint fps);
            float spxf = Convert.ToSingle(sp.getX()), spyf = Convert.ToSingle(sp.getY()), fpxf, fpyf;
            fpxf = Convert.ToSingle(fps.getX());
            fpyf = Convert.ToSingle(fps.getY());
            imp.DrawStartPoint(new PointF(spxf, spyf), new PointF(fpxf, fpyf));
            for (int i = 1; i <=n; i++)
            {
                t += 1.0 / n;
                _line.GetPoint(t, out IPoint fp);
                fpxf = Convert.ToSingle(fp.getX());
                fpyf = Convert.ToSingle(fp.getY());
                imp.DrawLine(new PointF(spxf,spyf), new PointF(fpxf, fpyf));
                if (i != n)
                {
                    spxf = fpxf;
                    spyf = fpyf;
                }
            }
            _line.GetPoint(1, out IPoint fpf);
            fpxf = Convert.ToSingle(fpf.getX());
            fpyf = Convert.ToSingle(fpf.getY());
            imp.DrawFinishPoint(new PointF(spxf, spyf), new PointF(fpxf, fpyf));
        }
    }
}
