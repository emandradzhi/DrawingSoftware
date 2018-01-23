using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class AngularShape
    {
        private Point _x;
        private Point _y;
        private double _height;
        private double _width;

        public AngularShape(Point x,Point y, double height,double width)
        {
            this._x = x;
            this._y = y;
            this._height = height;
            this._width = width;
        }

    }
}
