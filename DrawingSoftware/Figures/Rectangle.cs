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
            double area = Math.Abs((_A.X - _B.X)) * Math.Abs((_B.Y + _C.Y));
            return Math.Round(area,3);
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
