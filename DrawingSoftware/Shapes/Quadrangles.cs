using DrawingSoftware.Interfaces;
using DrawingSoftware.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public abstract void Draw();
        public abstract double CalculateSurfacAarea();
    }
}
