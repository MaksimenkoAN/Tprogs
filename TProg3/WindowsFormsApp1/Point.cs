using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Point : IPoint
    {
        private double X, Y;
        public Point() { }
        public Point(double _X, double _Y)
        {
            X = _X;
            Y = _Y;
        }
        public void setX(double _X) { X = _X; }
        public void setY(double _Y) { Y = _Y; }
        public double getX() { return X; }
        public double getY() { return Y; }
    }
}
