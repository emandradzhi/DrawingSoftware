using DrawingSoftware.Shapes;
using System;

namespace DrawingSoftware.Figures
{
    public class Rectangles : Parallelogram
    {
        private Point _A;
        private Point _B;
        private Point _C;
        public Rectangles(Point A, Point B, Point C) : base(A, B, C)
        {
            this._A = A;
            this._B = B;
            this._C = C;
        }
        public override double CalculateSurfacAarea()
        { 
            double area = (_A.X + _B.X)*(_B.Y + _C.Y);
            return area;
        }

        public override void Draw()
        {
            Console.WriteLine("A rectangle has been drawn");
        }
    }
}
