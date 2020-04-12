using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface ICurve
    {
       IPoint GetPoint(double t, out IPoint p);
    }
}