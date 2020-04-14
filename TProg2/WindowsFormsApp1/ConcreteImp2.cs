using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class ConcreteImp2 : AImplementor
    {
        public ConcreteImp2(Graphics g) : base(g) { }
        override public void DrawLine(PointF sp, PointF fp)
        {
            Pen pen = new Pen(Color.Black, 4);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(pen, sp, fp);
        }
        override public void DrawStartPoint(PointF sp, PointF fp)
        {
            Pen pen = new Pen(Color.Black, 4);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(pen, sp, fp);
        }
        override public void DrawFinishPoint(PointF sp, PointF fp)
        {
            Pen pen = new Pen(Color.Black, 4);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(pen, sp, fp);
        }
    }
}
