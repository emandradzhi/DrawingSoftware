using System.Collections.ObjectModel;

namespace DrawingSoftware.BinaryTree
{

    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base (){ }

        public NodeList(int initialSize)
        {
            for (int i = 0; i < initialSize; i++)
            {
                base.Items.Add(default(Node<T>));
            }
        }
        public Node<T> FindBySurficeArea(NodeList<T> surficeArea)
        {
            foreach (Node<T> node in Items)
            {
                if (node.SurfaceArea.Equals(surficeArea))
                {
                    return node;
                }
            }
            return null;
        }
    }
}
