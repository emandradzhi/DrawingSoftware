using DrawingSoftware.Interfaces;
using DrawingSoftware.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Figures
{
    public class Triangle : Polygon
    {
        public Triangle(Point A, Point B, Point C) : base(A, B, C)
        {

        }
        public override void CalculateSurfacAarea()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            Console.WriteLine("A triangle has been drawn");
        }
    }
}
