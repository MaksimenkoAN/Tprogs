using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Line : ACurve
    {
        public Line(IPoint _A, IPoint _B) : base(_A, _B) { }
        override public IPoint GetPoint(double t, out IPoint p)
        {
            IPoint newP = new Point();
            newP.setX((1 - t) * a.getX() + t * b.getX());
            newP.setY((1 - t) * a.getY() + t * b.getY());
            p = newP;
            return p;
        }
    }
}
