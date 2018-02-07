using DrawingSoftware.Interfaces;
using System;

namespace DrawingSoftware.BinaryTreeSearch
{
    public class Node<T> where T:IFigure
    {
        public string _name;
        public double _value;
        public  Node<T> _rigthLeaf;
        public  Node<T> _leftLeaf;
        public Node(T data)
        {
            this._name = data.ToString();
            this._value = data.CalculateSurfacAarea();
            _leftLeaf = null;
            _rigthLeaf = null;
        }
    }
}
