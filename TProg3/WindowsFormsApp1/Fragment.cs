using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Fragment: DECORATOR
    {
        private double t_start, t_finish;
        public Fragment(ICurve curve, double t1, double t2) : base(curve)
        {
            t_start = Math.Min(t1, t2);
            t_finish = Math.Max(t1, t2);
        }
        public override IPoint GetPoint(double t, out IPoint p)
        {
            if (t == 0.0)
                t = t_start;
            else if (t == 1.0)
                t = t_finish;
            else if ((0.0 < t) && (t < 1.0))
                t = t_start + t * (t_finish - t_start);
            p = this.component.GetPoint(t, out IPoint p_result);
            return p;
        }
    }
}