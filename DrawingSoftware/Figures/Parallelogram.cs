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
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            Console.WriteLine("A parallelogram has been drawn");
        }

    }
}
        

