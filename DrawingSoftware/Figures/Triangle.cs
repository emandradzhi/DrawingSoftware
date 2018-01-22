using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    class Triangle : IDraw //,ISurfaceArea
    {
        private double _a, _b, _c,_height;

        public Triangle(double a,double b,double c, double d,double height)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._height = height;
        }
        //public void CalculateSurfacAarea()
        //{
        //    Console.WriteLine("The surface area of the triangle is:" + (A*h)/2);
        //}

        public void Draw()
        {
            Console.WriteLine("A triangle has been drawn");
        }
    }
}
