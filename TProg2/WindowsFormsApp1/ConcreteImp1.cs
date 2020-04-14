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
        public ConcreteImp1(Graphics g) : base(g) { }
        override public void DrawLine(PointF sp, PointF fp) 
        {
            g.DrawLine(new Pen(Color.Green, 4), sp, fp);
        }
        override public void DrawStartPoint(PointF sp, PointF fp)
        {
            Pen pen = new Pen(Color.Green, 4);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            g.DrawLine(pen, sp, fp);
        }
        override public void DrawFinishPoint(PointF sp, PointF fp)
        {
            Pen pen = new Pen(Color.Green, 4);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(pen, sp, fp);
        }
    }
}
