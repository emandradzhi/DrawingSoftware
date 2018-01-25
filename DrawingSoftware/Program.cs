using DrawingSoftware.Figures;

namespace DrawingSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 2);
            Point C = new Point(2, 2);
            Quadrangle q = new Rectangle(A, B, C);
            q.Draw();
            System.Console.WriteLine(q.CalculateSurfacAarea());
        }
    }
}
