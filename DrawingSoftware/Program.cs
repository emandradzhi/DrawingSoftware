using DrawingSoftware.BinaryTreeSearch;
using DrawingSoftware.Factories;
using DrawingSoftware.Shapes;
using System.Collections.Generic;
using System;

namespace DrawingSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(1, 1);
            Point B = new Point(3, 1);
            Point C = new Point(4, 3);

            Point A1 = new Point(1, 1);
            Point B1 = new Point(3, 1);
            Point C1 = new Point(3, 3);

            List<Parallelogram> parall = new List<Parallelogram>();
            AbstractFactory af = new AbstractFactory();

            for (int i = 0; i < 10; i++)
            {
                var shape = af.CreateShape(A, B, C);
                var shape1 = af.CreateShape(A1, B1, C1);
                parall.Add(shape);
                parall.Add(shape1);
            }

            BinaryTree<Parallelogram> btree = new BinaryTree<Parallelogram>();

            foreach (var item in parall)
            {
                Console.WriteLine(item.CalculateSurfacAarea().ToString());
                btree.Insert(item);
            }

            Console.WriteLine("========================================");
            btree.Inorder();
            Console.ReadKey(true);
            
        }
    }
}
