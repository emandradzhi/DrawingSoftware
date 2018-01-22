using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class OvalShape
    {
        private double _x;
        private double _y;
        private double _radius;

        public OvalShape(double x, double y, double radius)
        {
            this._x = x;
            this._y = y;
            this._radius = radius;
        }
    }
}
