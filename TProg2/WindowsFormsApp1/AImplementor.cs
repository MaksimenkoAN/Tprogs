using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    abstract class AImplementor
    {
        protected Graphics g;
        public AImplementor(Graphics _g)
        {
            g = _g;
        }
        abstract public void DrawLine(PointF sp, PointF fp);
        abstract public void DrawStartPoint(PointF sp, PointF fp);
        abstract public void DrawFinishPoint(PointF sp, PointF fp);
    }
}
