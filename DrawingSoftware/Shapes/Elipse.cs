using DrawingSoftware.Interfaces;
using System;

namespace DrawingSoftware.Shapes
{
    public abstract class Elipse : IFigure
    {
        //To draw an elipse we need a center point with X and Y and a radius point with X and Y
        private Point _center;

        private double _radius;
        private double _fociA;
        private double _fociB;
        private double _distance;

        protected Elipse(Point center, double radius)
        {
            this._center = center;

            this._radius = radius;
        }
        public Elipse(Point center, double fociA, double fociB, double distance)
        {
            this._center = center;
            this._fociA = fociA;
            this._fociB = fociB;
            this._distance = distance;
        }

        public void Draw()
        {
            Console.WriteLine("An elipse has been drawn");
        }

        public double CalculateSurfacAarea()
        {
            throw new NotImplementedException();
        }
    }
}
