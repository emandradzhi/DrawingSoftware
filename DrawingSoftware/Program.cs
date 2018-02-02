using DrawingSoftware.BinaryTree;
using DrawingSoftware.Factories;
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

            AbstractFactory af = new AbstractFactory();
            var shape = af.CreateShape(A,B,C);
            shape.Draw();
            
            BinaryTree<double> btree = new BinaryTree<double>();
            
        }
    }
}
