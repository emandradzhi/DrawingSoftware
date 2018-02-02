using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.BinaryTree
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode() : base() { }
        public BinaryTreeNode(BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            // Hard coded value of 2 because binary trees have only 2 childs
            NodeList<T> children = new NodeList<T>(2);
            children[0] = left;
            children[1] = right;

        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (true)
                {
                    return null;
                }
                else
                {
                  
                }
            }
            set
            {
                if (true //base.SurfaceArea == null)
                {
                    //base.SurfaceArea = new NodeList<T>(2);
                }
              //  base.SurfaceArea[0] = value;
            }
        }
        public BinaryTreeNode<T> Right
        {
            get
            {
                if (base.SurfaceArea == null)
                {
                    return null;
                }
                else
                {
                    return (BinaryTreeNode<T>)base.SurfaceArea[1];
                }
            }
            set
            {
                if (base.SurfaceArea == null)
                {
                    base.SurfaceArea = new NodeList<T>(2);
                }
                base.SurfaceArea[1] = value;
            }


        }
    }
}