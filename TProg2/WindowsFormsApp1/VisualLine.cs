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
        public VisualLine(AImplementor _imp, IPoint _a, IPoint _b):base(_imp)
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
        override public void Draw(int n, Graphics g)
        {
            ICurve _line = new Line(a, b);
            IPoint sp = a;
            double t = 0;
            float spxf = Convert.ToSingle(sp.getX()), spyf = Convert.ToSingle(sp.getY()), fpxf = 0, fpyf = 0;
            imp.DrawStartPoint(new PointF(spxf, spyf), g);
            for (int i = 1; i <= n; i++)
            {
                t += 1.0 / n;
                _line.GetPoint(t, out IPoint fp);
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
