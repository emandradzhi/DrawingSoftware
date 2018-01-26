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
            //Calculate the diagonls
            double d1 = ParallelogramUtilities.FindLength(_A, _C);
            double d2 = ParallelogramUtilities.FindLength(_D, _B);

            return (d1 * d2) / 2;
        }
        public override void Draw()
        {
            Console.WriteLine("A rhombus has been drawn");
        }
    }
}

