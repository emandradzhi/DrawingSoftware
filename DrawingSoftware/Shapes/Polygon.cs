using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class Polygon : IFigure
    {
        protected Point _A;
        protected Point _B;
        protected Point _C;
        protected Point _D;

        //protected double _height;
        //protected double _width;

        public Polygon(Point A, Point B, Point C, Point D)
        {
            this._A = A;
            this._B = B;
            this._C = C;
            this._D = D;
        }
        public Polygon(Point A, Point B, Point C)
        {
            this._A = A;
            this._B = B;
            this._C = C;
        }

        public abstract void Draw();
        public abstract void CalculateSurfacAarea();
    }
}
