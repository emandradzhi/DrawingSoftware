using DrawingSoftware.Interfaces;
using System;

namespace DrawingSoftware.Figures
{
    public abstract class Quadrangle : IFigure
    {
        protected Point _A;
        protected Point _B;
        protected Point _C;
        protected Point _D;
        public Quadrangle(Point A, Point B, Point C, Point D)
        {
            this._A = A;
            this._B = B;
            this._C = C;
            this._D = D;
        }
        public virtual void Draw()
        {
            Console.WriteLine("A quadrangle has been drawn");
        }
        public virtual double CalculateSurfacAarea()
        {
            var rand = new Random(1500).NextDouble();

            return rand;
        }
    }
}
