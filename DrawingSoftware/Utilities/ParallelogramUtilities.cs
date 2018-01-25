using System;

namespace DrawingSoftware
{
    public static class ParallelogramUtilities
    {
        public static Point FindPoint(Point A, Point B, Point C)
        {
            Point _D = new Point((A.X + B.X) - C.X, (A.Y + B.Y) - C.Y);
            return _D;
        }
        public static double FindLength(Point A, Point B)
        {
            double l = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
            return l;
        }
    }
}
