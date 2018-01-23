using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class OvalShape : IFigure
    {
        protected Point _center;
        
        protected double _radius;
        protected double _fociA;
        protected double _fociB;
        protected double _distance;

        public OvalShape(Point center, double radius)
        {
            this._center = center;
            
            this._radius = radius;
        }

        public OvalShape(Point center,double fociA, double fociB,double distance)
        {
            this._center = center;
            this._fociA = fociA;
            this._fociB = fociB;
            this._distance = distance;
        }

        public abstract void CalculateSurfacAarea();
        public abstract void Draw();
    }
}
