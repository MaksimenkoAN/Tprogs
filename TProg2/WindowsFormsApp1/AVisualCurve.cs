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
        protected IImplementor imp;
        protected int n;
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