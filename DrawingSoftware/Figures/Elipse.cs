using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public class Elipse : OvalShape
    {
        //private double _fociA, _fociB, _center;
        //public Elipse(double fociA,double fociB,double center)
        //{
        //    this._fociA = fociA;
        //    this._fociB = fociB;
        //    this._center = center;
        //}
        //public void Draw()
        //{
        //    if (_fociA == _fociB)
        //    {
        //        double sum = (_fociA+_fociB )/ 2
        //        Circle circle = new Circle(sum,_center);
        //        circle.Draw();
        //    }
        //    else
        //    {
        //        Console.WriteLine("An elipse has been drawn");
        //    }
        //}
        public Elipse(double x, double y, double radius) : base(x, y, radius)
        {
        }
    }
}
