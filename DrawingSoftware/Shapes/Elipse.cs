using DrawingSoftware.Interfaces;
using System;

namespace DrawingSoftware.Shapes
{
    public abstract class Elipse : IFigure
    {
        protected Point _center;
        protected Point _fociA;
        protected Point _fociB;

        protected double _distance;
        
        public Elipse(Point center, Point fociA, Point fociB, double distance)
        {
            this._center = center;
            this._fociA = fociA;
            this._fociB = fociB;
            this._distance = distance;
        }
        protected Elipse(Point center, double distance)
        {
            this._center = center;
            this._distance = distance;
        }
      
        public virtual void Draw()
        {
            Console.WriteLine("An elipse has been drawn");
        }

        public virtual double CalculateSurfacAarea()
        {
            throw new NotImplementedException();
        }
    }
}
