using DrawingSoftware.Shapes;
using System;

namespace DrawingSoftware.Figures
{
    public class Rhombus : Parallelogram
    {
        private Point _A;
        private Point _B;
        private Point _C;
        public Rhombus(Point A, Point B, Point C) : base(A, B, C)
        {
            this._A = A;
            this._B = B;
            this._C = C;
        }
        public override double CalculateSurfacAarea()
        {
           var _D =  findPoint(_A, _B, _C);
           double d1 = Math.Sqrt(Math.Pow((_C.X - _A.X), 2) + Math.Pow((_C.Y - _A.Y), 2));
           double d2 = Math.Sqrt(Math.Pow((_D.X - _B.X), 2) + Math.Pow((_D.Y - _B.Y), 2));

           return (d1 * d2) / 2; 
        }
        public override void Draw()
        {
            Console.WriteLine("A rhombus has been drawn");
        }
        protected override Point findPoint(Point A, Point B, Point C)
        {
            return findPoint(A, B, C);
        }
    }
}

