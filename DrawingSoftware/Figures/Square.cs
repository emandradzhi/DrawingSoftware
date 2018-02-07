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
            double side = Math.Pow((_A.X + _B.X), 2);
            return side;
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
