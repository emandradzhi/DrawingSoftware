using DrawingSoftware.Interfaces;
using System;

namespace DrawingSoftware.Figures
{
    public class Triangle : IFigure
    {
        protected Point _A;
        protected Point _B;
        protected Point _C;
        public Triangle(Point A, Point B, Point C)
        {
            this._A = A;
            this._B = B;
            this._C = C;
        }
        public double CalculateSurfacAarea()
        {
            double AB = ParallelogramUtilities.FindLength(_A, _B);
            double AC = ParallelogramUtilities.FindLength(_A, _C);
            double BC = ParallelogramUtilities.FindLength(_B, _C);

            double p = AB + AC + BC;
            double area = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));

            return area;
        }

        public void Draw()
        {
            Console.WriteLine("A triangle has been drawn");
        }
    }
}
