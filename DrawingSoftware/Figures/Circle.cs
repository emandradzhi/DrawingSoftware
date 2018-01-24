using System;

namespace DrawingSoftware.Shapes
{
    public class Circle : Elipse
    { // To draw a circle we need a center point and raidus lentgth
        private Point _center;
        private double _radius;
        
        public Circle(Point center, double radius): base(center, radius)
        {
            this._center = center;
            this._radius = radius;
        }

        public new double CalculateSurfacAarea()
        {
            double area = Math.PI * _radius;
            return area;
        }

        public new void Draw()
        {
            Console.WriteLine("A circle has been drawn");
        }
    }
}
