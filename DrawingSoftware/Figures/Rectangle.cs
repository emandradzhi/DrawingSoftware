using DrawingSoftware.Shapes;
using System;

namespace DrawingSoftware.Figures
{
    public class Rectangle : Parallelogram
    {
        public Rectangle(Point A, Point B, Point C) : base(A, B, C)
        {
        }
        public override double CalculateSurfacAarea()
        {
            double area = Math.Abs((_A.Y + _B.Y)) * Math.Abs((_B.X + _C.X));
            return area;
        }

        public override void Draw()
        {
            Console.WriteLine("A rectangle has been drawn");
        }
        public override string ToString()
        {
            return "Rectangle";
        }
    }
}
