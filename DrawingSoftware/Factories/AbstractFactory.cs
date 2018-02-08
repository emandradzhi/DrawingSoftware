using DrawingSoftware.Figures;
using DrawingSoftware.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Factories
{
    public class AbstractFactory
    {
        public AbstractFactory()
        {
           
        }
        public Parallelogram CreateShape(Point A, Point B, Point C)
        {
            Point D = ParallelogramUtilities.FindPoint(A,B,C);
            double AB = ParallelogramUtilities.FindLength(A, B);
            double BC = ParallelogramUtilities.FindLength(B, C);
            double CD = ParallelogramUtilities.FindLength(C, D);
            double AD = ParallelogramUtilities.FindLength(A, D);
            //Diagonals
            double d1 = ParallelogramUtilities.FindLength(A, C);
            double d2 = ParallelogramUtilities.FindLength(B, D);

            if (AB == AD && AB == BC && AB == CD && d1 != d2)
            {
                return new Rhombus(A, B, C);
            }
            else if (AB == AD && AB == BC && AB == CD && d1 == d2)
            {
                return new Square(A, B, C);
            }
            else if (AB == CD && AD == BC && d1 == d2)
            {
                return new Rectangle(A, B, C);
            }
            else
            {
                return new Parallelogram(A, B, C);
            }

        }
    }
}
