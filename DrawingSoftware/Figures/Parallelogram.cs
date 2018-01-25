using DrawingSoftware.Figures;
using System;

namespace DrawingSoftware.Shapes
{
    public class Parallelogram : Quadrangle
    {
        public Parallelogram(Point A, Point B, Point C) :
            base(A, B, C, Utilities.FindPoint(A, B, C))
        {
        }
        public override double CalculateSurfacAarea()
        {
            double a = (_B.X - _A.X);
            double h = new Random(50).NextDouble();
            double area = a * h;
            return h;
        }
        public override void Draw()
        {
            Console.WriteLine("A parallelogram has been drawn");
        }
    }
}


