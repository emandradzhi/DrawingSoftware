using DrawingSoftware.Interfaces;
using System;

namespace DrawingSoftware.Figures
{
    public class Triangle : IFigure
    {
        public Triangle(Point A, Point B, Point C)
        {

        }
        public double CalculateSurfacAarea()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            Console.WriteLine("A triangle has been drawn");
        }
    }
}
