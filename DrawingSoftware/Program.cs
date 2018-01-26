using DrawingSoftware.Figures;
using DrawingSoftware.Shapes;

namespace DrawingSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 2);
            Point C = new Point(2, 2);
            Parallelogram p = new Parallelogram(A, B, C);
            p.Draw();
            //System.Console.WriteLine(p.CalculateSurfacAarea());
        }
    }
}
