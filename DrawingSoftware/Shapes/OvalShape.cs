using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class OvalShape
    {
        protected Point _center;
        
        protected double _radius;

        public OvalShape(Point center, double radius)
        {
            this._center = center;
            
            this._radius = radius;
        }
    }
}
