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
        abstract public void DrawLine(PointF sp, PointF fp, Graphics g);
        abstract public void DrawStartPoint(PointF p, Graphics g);
        abstract public void DrawFinishPoint(PointF ps, PointF pf, Graphics g);
    }
}
