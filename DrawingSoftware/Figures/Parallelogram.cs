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
            double a = Math.Abs((_A.X - _B.X));
            double h = Math.Abs((_B.Y - _C.Y));
            double area = a * h;
            return Math.Round(area,3);
        }
        public override void Draw()
        {
            Console.WriteLine("A parallelogram has been drawn");
        }
        public override string ToString()
        {
            return "Parallelogram";
        }
    }
}


