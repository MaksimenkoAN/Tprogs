using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IPoint
    {
        void setX(double X);
        void setY(double Y);
        double getX();
        double getY();
    }
}
