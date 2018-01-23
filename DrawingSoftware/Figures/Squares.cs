using DrawingSoftware.Interfaces;
using DrawingSoftware.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Figures
{
    public class Squares : Parallelogram
    {
        public Squares(Point A, Point B, Point C, Point D) : base(A, B, C, D)
        {

        }

        public override void CalculateSurfacAarea()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
