namespace DrawingSoftware.BinaryTreeSearch
{
    public class Node
    {
        public double _data;
        public  Node _rigthLeaf;
        public  Node _leftLeaf;
        public Node(double data)
        {
            this._data = data;
            _leftLeaf = null;
            _rigthLeaf = null;
        }
    }
}
