using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MoveTo: DECORATOR
    {
        private IPoint p;
        private double new_x, new_y;
        public MoveTo(ICurve curve, IPoint p, double pos):base(curve)
        {
            this.p = p;
            IPoint new_p;
            if ((Math.Min(0.0, pos) == 0) && (Math.Max(1.0, pos) == 1))
                new_p = this.component.GetPoint(pos, out IPoint res);
            else
                new_p = this.component.GetPoint(0, out IPoint res);
            new_x = p.getX() - new_p.getX();
            new_y = p.getY() - new_p.getY();
        }
        public double GetX()
        {
            return new_x;
        }
        public double GetY()
        {
            return new_y;
        }
        public override IPoint GetPoint(double t, out IPoint p)
        {
            IPoint new_p = this.component.GetPoint(t, out IPoint res);
            double x = new_p.getX() + new_x;
            double y = new_p.getY() + new_y;
            p = new Point(x, y);
            return p;
        }
    }
}
