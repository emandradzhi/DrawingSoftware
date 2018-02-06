namespace DrawingSoftware.BinaryTreeSearch
{
    public class Node
    {
        public string _name;
        public double _data;
        public  Node _rigthLeaf;
        public  Node _leftLeaf;
        public Node(string name, double data)
        {
            this._name = name;
            this._data = data;
            _leftLeaf = null;
            _rigthLeaf = null;
        }
    }
}
