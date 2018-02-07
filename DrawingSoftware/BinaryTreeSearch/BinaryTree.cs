using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;

namespace DrawingSoftware.BinaryTreeSearch
{
    public class BinaryTree<T> where T:IFigure
    {
        private Node<T> _root;
        
        public BinaryTree()
        {
            _root = null;
        }
        public Node<T> ReturnRoot()
        {
            return _root;
        }
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (_root == null)
            {
                _root = newNode;
                return;
            }
            else
            {
                Node<T> current = _root;
                Node<T> parent;
                while (true)
                {
                    parent = current;

                    if (newNode._value < current._value)
                    {
                        current = current._leftLeaf;
                        if(current == null)
                        {
                            parent._leftLeaf = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current._rigthLeaf;
                        if (current == null)
                        {
                            parent._rigthLeaf = newNode;
                            return;
                        }
                    }
                }
            }
        }
       
        
        public void Search(double area)
        {
             Search(_root, area);
        }

        private void Search(Node<T> node,double area)
        {
            if (node == null || node._value == area)
            {
                Console.WriteLine(node._name);
            }
            else if (node._value < area)
            {
                Search(node._rigthLeaf, area);
            }
            else
            {
                Search(node._leftLeaf, area);
            }
        }

        public void Inorder()
        {
            Inorder(_root);
        }

        private void Inorder(Node<T> root)
        {
            if (root != null)
            {
                Inorder(root._leftLeaf);
                Console.WriteLine(root._value + "  " + root._name);
                Inorder(root._rigthLeaf);
            }
        }
    }
}
