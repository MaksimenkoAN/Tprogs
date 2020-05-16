﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IImplementor
    {
        void DrawLine(PointF sp, PointF fp);
        void DrawStartPoint(PointF sp, PointF fp);
        void DrawFinishPoint(PointF sp, PointF fp);
    }
}
