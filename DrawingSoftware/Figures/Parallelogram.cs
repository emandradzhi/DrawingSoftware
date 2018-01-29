using DrawingSoftware.Figures;
using System;

namespace DrawingSoftware.Shapes
{
    public class Parallelogram : Quadrangle
    {
        public Parallelogram(Point _A, Point _B, Point _C) :
            base(_A, _B, _C, ParallelogramUtilities.FindPoint(_A, _B, _C))
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
            Console.WriteLine("A parallelogram has been drawn");
        }
    }
}


