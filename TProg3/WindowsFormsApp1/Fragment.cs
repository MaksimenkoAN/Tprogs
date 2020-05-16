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
            p = this.component.GetPoint(t_start, out IPoint result);
            if (t == 0.0)
                return p;
            else if (t == 1.0)
                p = this.component.GetPoint(t_finish, out IPoint p_finish);
            else if ((t_start < t) && (t > t_finish))
                p = this.component.GetPoint((t_start + t * (t_finish - t_start)), out IPoint p_result);
            return p;
        }
    }
}