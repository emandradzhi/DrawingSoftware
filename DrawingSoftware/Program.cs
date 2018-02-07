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

            Point A2 = new Point(1, 1);
            Point B2 = new Point(5, 1);
            Point C2 = new Point(5, 5);

            Point A3 = new Point(1, 1);
            Point B3 = new Point(8, 1);
            Point C3 = new Point(8, 3);

            List<Parallelogram> parall = new List<Parallelogram>();
            AbstractFactory af = new AbstractFactory();

            
            var shape = af.CreateShape(A, B, C);
            var shape1 = af.CreateShape(A1, B1, C1);
            var shape2 = af.CreateShape(A2, B2, C2);
            var shape3 = af.CreateShape(A3, B3, C3);
            parall.Add(shape);
            parall.Add(shape1);
            parall.Add(shape2);
            parall.Add(shape3);


            BinaryTree<Parallelogram> btree = new BinaryTree<Parallelogram>();

            foreach (var item in parall)
            {
                Console.WriteLine(item.CalculateSurfacAarea().ToString() + "Inserted");
                btree.Insert(item);
            }

            Console.WriteLine("=================Inorder=======================");
            btree.Inorder();
            Console.WriteLine("==================Search======================");
            btree.Search(20);
            Console.WriteLine("========================================");
            Console.ReadKey(true);
            
        }
    }
}
