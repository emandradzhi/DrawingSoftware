using DrawingSoftware.Interfaces;
using DrawingSoftware.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Figures
{
    public class Triangle : IFigure
    {
        public Triangle(Point A, Point B, Point C)
        {

        }
        public double CalculateSurfacAarea()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            Console.WriteLine("A triangle has been drawn");
        }
    }
}
