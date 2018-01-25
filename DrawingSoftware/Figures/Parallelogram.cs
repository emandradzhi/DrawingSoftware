using DrawingSoftware.Figures;
using System;

namespace DrawingSoftware.Shapes
{
    public class Parallelogram : Quadrangle
    {
        public Parallelogram(Point A, Point B, Point C) :
            base(A, B, C, ParallelogramUtilities.FindPoint(A, B, C))
        {
        }
        public override double CalculateSurfacAarea()
        {
            double a = (_B.X - _A.X);
            double h = new Random(50).NextDouble();
            double area = a * h;
            return area;
        }
        public override void Draw()
        {
            double d1;
            double d2;
            if ((_B.X - _A.X) == (_D.X - _C.X) && (_D.Y - _A.Y) == (_C.Y - _B.Y))
            { 
            Console.WriteLine("A parallelogram has been drawn");
            }
        }
    }
}


