using DrawingSoftware.Interfaces;
using DrawingSoftware.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            Console.WriteLine("A rhombus has been drawn");
        }
    }
}

