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
        protected AImplementor imp;
        public AImplementor AImplementor
        {
            set { imp = value; }
        }
        public AVisualCurve(AImplementor _imp)
        {
            imp = _imp;
        }
        public abstract void Draw(int n, Graphics g);
        public abstract IPoint GetPoint(double t, out IPoint p);
    }
}