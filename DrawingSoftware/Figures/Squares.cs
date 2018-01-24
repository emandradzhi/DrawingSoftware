using DrawingSoftware.Interfaces;
using DrawingSoftware.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Figures
{
    public class Squares : Rectangles
    {
        private Point _A;
        private Point _B;
        private Point _C;
        public Squares(Point A, Point B, Point C) : base(A, B, C)
        {
            this._A = A;
            this._B = B;
            this._C = C;
        }

        public override double CalculateSurfacAarea()
        {
            double side = Math.Pow((_A.X + _B.X), 2);
            return side;
            
        }

        public override void Draw()
        {
            Console.WriteLine("A square has been drawn");
        }
    }
}
