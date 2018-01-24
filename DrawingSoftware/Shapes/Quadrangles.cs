using DrawingSoftware.Interfaces;
using System;

namespace DrawingSoftware.Figures
{
    public abstract class Quadrangles : IFigure
    {
        private Point _A;
        private Point _B;
        private Point _C;
        private Point _D;
        public Quadrangles(Point A, Point B, Point C, Point D)
        {
            this._A = A;
            this._B = B;
            this._C = C;
            this._D = D;
        }
        public Quadrangles(Point A, Point B, Point C)
        {
            this._A = A;
            this._B = B;
            this._C = C;
        }
        public virtual void Draw()
        {
            Console.WriteLine("A quadrangles has been drawn");
        }
        public virtual double CalculateSurfacAarea()
        {
            var rand = new Random(1500).NextDouble();

            return rand;
        }
        protected virtual Point findPoint(Point A, Point B, Point C)
        {
            Point _D = new Point();

            _D.X = (A.X + B.X) - C.X;
            _D.Y = (A.Y + B.Y) - C.Y;

            return _D;
        }
    }
}
