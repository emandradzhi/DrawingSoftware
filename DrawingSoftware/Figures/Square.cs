using System;

namespace DrawingSoftware.Figures
{
    public class Square : Rectangle
    {
        public Square(Point A, Point B, Point C) : base(A, B, C)
        {
        }

        public override double CalculateSurfacAarea()
        {
            double area = Math.Pow(Math.Abs((_A.X - _B.X)), 2);
            return Math.Round(area,3);
        }

        public override void Draw()
        {
            Console.WriteLine("A square has been drawn");
        }
        public override string ToString()
        {
            return "Square";
        }
    }
}
