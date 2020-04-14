using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class ConcreteImp1: AImplementor
    {
        override public void DrawLine(PointF sp, PointF fp, Graphics g) 
        {
            g.DrawLine(new Pen(Color.Green, 4), sp, fp);
        }
        override public void DrawStartPoint(PointF p, Graphics g)
        {
            Pen pen = new Pen(Color.Green, 4);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            g.DrawLine(pen, p, new PointF((p.X+1), (p.Y+1)));
        }
        override public void DrawFinishPoint(PointF ps, PointF pf, Graphics g)
        {
            Pen pen = new Pen(Color.Green, 4);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(pen, ps, pf);
        }
    }
}
