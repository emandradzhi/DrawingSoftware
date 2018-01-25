using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware
{
    public static class Utilities
    {
        public static Point FindPoint(Point A, Point B, Point C)
        {
            Point _D = new Point((A.X + B.X) - C.X, (A.Y + B.Y) - C.Y);
            return _D;
        }
    }
}
