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
        public abstract void Draw(Pen _pen, object sender, PaintEventArgs e, double t);
        public abstract IPoint GetPoint(double t, out IPoint p);
    }
}
