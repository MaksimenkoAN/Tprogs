using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class DECORATOR: ICurve
    {
        protected ICurve component;
        public DECORATOR(ICurve curve)
        {
            component = curve;
        }
        public void SetComponent(ICurve curve)
        {
            component = curve;
        }
        public abstract IPoint GetPoint(double t, out IPoint p);
    }
}
