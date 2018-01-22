using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    class Parallelogram : AngularShape
    {
        //private double _a, _b, _alfa, _beta;


        //public Parallelogram(double a, double b, double alfa, double beta)
        //{
        //    this._a = a;
        //    this._b = b;
        //    this._alfa = alfa;
        //    this._beta = beta;
        //}

        //public void Draw()
        //{

        //    if ((_a == _b) &&  (_alfa == 90) && (_alfa == _beta))
        //    {
        //        Console.WriteLine("A square has been drawn");
        //    }


        //    Console.WriteLine("A parallelogram has been drawn");
        //}
        public Parallelogram(double x, double y, double height, double width) : base(x, y, height, width)
        {
        }
    }
}
