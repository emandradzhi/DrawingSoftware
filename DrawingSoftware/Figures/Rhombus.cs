using DrawingSoftware.Shapes;
using System;

namespace DrawingSoftware.Figures
{
    public class Rhombus : Parallelogram
    {
        public Rhombus(Point A, Point B, Point C) : base(A, B, C)
        {
        }
        public override double CalculateSurfacAarea()
        {
            double d1 = Math.Sqrt(Math.Pow((_C.X - _A.X), 2) + Math.Pow((_C.Y - _A.Y), 2));
            double d2 = Math.Sqrt(Math.Pow((_D.X - _B.X), 2) + Math.Pow((_D.Y - _B.Y), 2));

            return (d1 * d2) / 2;
        }
        public override void Draw()
        {
            Console.WriteLine("A rhombus has been drawn");
        }
    }
}

