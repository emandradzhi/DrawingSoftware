using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class Quadrangle : AngularShape, IDraw
    {
        public Quadrangle(Point x, Point y, double height, double width) : base(x, y, height, width)
        {

        }

        public void Draw()
        {
            Console.WriteLine("A quadrangle has been drawn");
        }
    }
}
