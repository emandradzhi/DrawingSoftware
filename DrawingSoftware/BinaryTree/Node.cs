using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.BinaryTree
{
    public class Node<T>
    {
        // Should have:

        //-- bool isLeaf() 
        //-- Add
        //-- Search
        //-- Display

        // Expect to be given surface area in form of colection
        // Трябва ми data/стойност на node, на база на който мога да определя ляв или десен член е той
        private NodeList<T> _shapes = null;
        private Node<T> rigthLeaf { get; set; } 
        private  Node<T> leftLeaf { get; set; } 
        public Node() { }

        // On creation takes a surfaceArea [colection]
        public Node(NodeList<T> shapes)
        {
            this._shapes = shapes;
        }
        public bool isLeaf(Node<T> node)
        {
            return (node.leftLeaf == null && node.rigthLeaf == null);
        }
        //Трябва да приема node, а той от своя страна трябва да има листа
        //В случая трябва да направим клас дете , което има дясно и ляво листо 
        public void AddElement(Node<T> leaf)
        {
            if(leaf.leftLeaf != null && leaf.rigthLeaf != null){
                _shapes.Add(leaf);
            }
        }
    }
}
