using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;

namespace DrawingSoftware.BinaryTreeSearch
{
    public class BinaryTree<T> where T : IFigure
    { 

        // TODO: Find a way to store shapes with eaqual surfice area but 
        // different shape, and on search i should see every shape with that area


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
                        if (current == null)
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
        public Node<T> Search(double area)
        {
            return Search(_root, area);
        }

        private Node<T> Search(Node<T> node, double area)
        {
            area = Math.Round(area, 3);
            if (node == null)
            {
                return null;
            }
            else if (node._value == area)
            {
                return node;
            }
            else if (node._value < area)
            {
                return Search(node._rigthLeaf, area);
            }
            else
            {
                return Search(node._leftLeaf, area);
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
