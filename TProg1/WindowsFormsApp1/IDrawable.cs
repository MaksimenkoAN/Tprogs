using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    interface IDrawable
    {
        void Draw(Pen _pen, object sender, PaintEventArgs e, double t);
    }
}