using DrawingSoftware.Figures;
using System;

namespace DrawingSoftware.Shapes
{
    public class Parallelogram : Quadrangles
    {
        private Point _A;
        private Point _B;
        private Point _C;
        public Parallelogram(Point A, Point B, Point C) : base(A, B, C)
        {
            this._A = A;
            this._B = B;
            this._C = C;
        }
        public override double CalculateSurfacAarea()
        {
            double a = (_B.X - _A.X);
            double h = new Random(50).NextDouble();
            double area = a * h;
            return h;
        }
        public override void Draw()
        {
            Console.WriteLine("A parallelogram has been drawn");
        }
    }
}
        

