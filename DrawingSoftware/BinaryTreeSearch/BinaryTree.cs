using System;

namespace DrawingSoftware.BinaryTreeSearch
{
    public class BinaryTree
    {
        private Node root;
        
        public BinaryTree(){
            root = null;
        }
       
        // За създване на ноуд ни трябват данни, подаваме данни и ги запзваме на нов ноуд
        public void Insert(double data)
        {
            // Проверяваме дали клона е празен
            Node newNode = new Node(data);
            newNode._data = data;
            // ако да новият ноуд става корен
            if (root == null)
            {
                root = newNode;
            }
            // ако не добавяме ноуда
            else
            {
                // Взимаме стойността на корена и я слагаме на променлива
                Node current = root;

                // Създаваме родител
                Node parent;
                while (true)
                {
                    parent = current;
                    // ако подадените данни са по малки от настоящите
                    if (data < current._data)
                    {
                        // слизаме едно ниво надолу
                        current = current._leftLeaf;
                        if(current == null)
                        {
                            //когато стигнем празно листо спираме
                            parent._leftLeaf = newNode;
                            return;
                        }
                    }
                    // ако данните са по-големи от настоящите 
                    else
                    {
                        // качваме се ниво нагоре
                        current = current._rigthLeaf;
                        if (current == null)
                        {
                            //последното празно място
                            parent._rigthLeaf = newNode;
                            return;
                        }
                    }
                }
            }
        }
        
        public void Display(Node node)
        {
            if (node != null)
            {
               Console.WriteLine(node._data.ToString() + node._leftLeaf.ToString() + node._rigthLeaf.ToString());
            }
            else
            {
                return;
            }
        }
    }
}
