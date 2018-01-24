using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class Elipse : IFigure
    {
        //To draw an elipse we need a center point with X and Y and a radius point with X and Y
        protected Point _center;

        protected double _radius;
        protected double _fociA;
        protected double _fociB;
        protected double _distance;

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
        public abstract double CalculateSurfacAarea();
        public abstract void Draw();
    }
}
