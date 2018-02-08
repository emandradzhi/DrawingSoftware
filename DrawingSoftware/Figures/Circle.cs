using System;

namespace DrawingSoftware.Shapes
{
    public class Circle : Elipse
    { 
        private double radius;
        public Circle(Point center, double distance) : base(center,distance)
        {
            this._center = center;
            this.radius = distance;
        }

        public new double CalculateSurfacAarea()
        {
            double area = Math.PI * radius;
            return Math.Round(area,3);
        }

        public new void Draw()
        {
            Console.WriteLine("A circle has been drawn");
        }
    }
}
