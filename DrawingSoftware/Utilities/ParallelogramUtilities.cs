using DrawingSoftware.Figures;
using DrawingSoftware.Shapes;
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

        //This method is finding the lenght between two points
        public static double FindLength(Point A, Point B)
        {
            double l = Math.Sqrt(Math.Pow(Math.Abs((B.X - A.X)), 2) + Math.Pow(Math.Abs((B.Y - A.Y)), 2));
            return l;
        }
        public static Parallelogram ConstructMechanism(Point A, Point B, Point C, Point D)
        {

            double AB = FindLength(A, B);
            double BC = FindLength(B, C);
            double CD = FindLength(C, D);
            double AD = FindLength(A, D);
            //Diagonals
            double d1 = FindLength(A, C);
            double d2 = FindLength(B, D);

            if (AB == AD && AB == BC && AB == CD && d1 != d2)
            {
                return new Rhombus(A, B, C);
            }
            else if (AB == CD && AD == BC && d1 == d2)
            {
                return new Rectangle(A, B, C);
            }
            else if (AB == AD && AB == BC && AB == CD && d1 == d2)
            {
                return new Square(A, B, C);
            }
            else
            {
                return new Parallelogram(A, B, C);
            }

        }

    }
}
