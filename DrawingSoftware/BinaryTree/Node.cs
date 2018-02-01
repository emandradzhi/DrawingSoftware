using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.BinaryTree
{
    public class Node<T>
    {
        private NodeList<T> _surfaceArea = null;

        public Node() { }
        public Node(NodeList<T> surfaceArea)
        {
            this._surfaceArea = surfaceArea;
        }
        public NodeList<T> SurfaceArea
        {
            get
            { 
                return _surfaceArea;
            }
            set
            {
                _surfaceArea = value;
            }
        }
    }
}
