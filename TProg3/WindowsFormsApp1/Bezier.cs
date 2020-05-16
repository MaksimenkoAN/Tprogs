using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bezier:ACurve
    {
        private IPoint C, D;
        public Bezier(IPoint _A, IPoint _B, IPoint _C, IPoint _D) : base(_A, _B) { C = _C; D = _D; }
        public IPoint GetC()
        {
            return C;
        }
        public IPoint GetD()
        {
            return D;
        }
        override public IPoint GetPoint(double t, out IPoint p)
        {
            IPoint newP = new Point();
            newP.setX(Math.Pow((1 - t), 3) * a.getX() + 3 * t * Math.Pow((1-t),2)*C.getX() + 3*Math.Pow(t,2)*(1-t)*D.getX()+Math.Pow(t,3)*b.getX());
            newP.setY(Math.Pow((1 - t), 3) * a.getY() + 3 * t * Math.Pow((1 - t), 2) * C.getY() + 3 * Math.Pow(t, 2) * (1 - t) * D.getY() + Math.Pow(t, 3) * b.getY());
            p = newP;
            return p;
        }
    }
}