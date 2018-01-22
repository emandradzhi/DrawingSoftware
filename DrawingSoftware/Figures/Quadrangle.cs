using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    class Quadrangle : IDraw,ISurfaceArea
    {
        private double _a, _b, _c, _d, _alfa, _beta, _gamma, _delta;

        public Quadrangle(double a,double b,double c, double d,double alfa,double beta,double gamma, double delta)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._d = d;
            this._alfa = alfa;
            this._beta = beta;
            this._gamma = gamma;
            this._delta = delta;
        }
        public void CalculateSurfacAarea()
        {
            //Console.WriteLine("The surface area of the quadrangle is:" + Math.Sqrt((s-A)*(s-B)*(s-C)*(s-D)-A*B*C*D*((Math.Cos(alfa) * Math.Cos(alfa))/2)));
        }

        public void Draw()
        {
            Console.WriteLine("A quadrangle has been drawn");
        }
    }
}
