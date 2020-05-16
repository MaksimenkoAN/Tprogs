using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    abstract class AVisualCurve: IDrawable, ICurve
    {
        private IImplementor imp;
        protected int n;
        protected void DrawLine(PointF sp, PointF fp) {
            imp.DrawLine(sp, fp);
        }
        protected void DrawStartPoint(PointF sp, PointF fp)
        {
            imp.DrawStartPoint(sp, fp);
        }
        protected void DrawFinishPoint(PointF sp, PointF fp)
        {
            imp.DrawFinishPoint(sp, fp);
        }
        public AImplementor AImplementor
        {
            set { imp = value; }
        }
        public AVisualCurve(IImplementor _imp, int _n)
        {
            imp = _imp;
            n = _n;
        }
        public abstract void Draw();
        public abstract IPoint GetPoint(double t, out IPoint p);
    }
}