using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class AngularShape
    {
        protected Point _A;
        protected Point _B;
        protected Point _C;

        protected double _height;
        protected double _width;

        public AngularShape(Point A,Point B,Point C, double height,double width)
        {
            this._A = A;
            this._B = B;
            this._C = C;
            this._height = height;
            this._width = width;
        }

    }
}
