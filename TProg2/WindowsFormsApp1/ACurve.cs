using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class ACurve: ICurve
    {
        protected IPoint a, b;

        public ACurve(IPoint A, IPoint B)
        {
            a = A;
            b = B;
        }
        public abstract IPoint GetPoint(double t, out IPoint p);
    }
}