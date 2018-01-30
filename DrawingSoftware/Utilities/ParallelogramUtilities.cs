using DrawingSoftware.Figures;
using DrawingSoftware.Shapes;
using System;

namespace DrawingSoftware
{
    public static class ParallelogramUtilities
    {
        public static Point FindPoint(Point A, Point B, Point C)
        {
            // Тemporarily X
            double _x1 = Math.Abs(B.X - C.X);
            // X wich should be returned
            double _x;
            if (_x1 != 0)
            {
                _x = A.X + _x1;
            } else
            {
                _x = A.X;
            }
            Point _D = new Point(_x, C.Y);
            return _D;
        }

        // This method is finding the lenght between two points
        public static double FindLength(Point A, Point B)
        {
            double l = Math.Sqrt(Math.Pow(Math.Abs((A.X - B.X)), 2) + Math.Pow(Math.Abs((A.Y - B.Y)), 2));
            return l;
        }
    }
}
