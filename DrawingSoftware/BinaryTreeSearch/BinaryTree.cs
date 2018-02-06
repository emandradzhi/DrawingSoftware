using System;
using System.Collections.Generic;

namespace DrawingSoftware.BinaryTreeSearch
{
    public class BinaryTree
    {
        private Node _root;
        
        public BinaryTree(){
            _root = null;
        }
        // Този метод връша корена на дървото
        public Node ReturnRoot()
        {
            return _root;
        }
        // За създване на ноуд ни трябват данни, подаваме данни и ги запзваме на нов ноуд
        public void Insert(string name, double data)
        {
            Node newNode = new Node(name, data);
            // Проверяваме дали клона е празен
            // ако да новият ноуд става корен
            if (_root == null)
            {
                _root = newNode;
            }
            // ако не добавяме ноуда
            else
            {
                // Взимаме стойността на корена и я слагаме на променлива
                Node current = _root;

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
                        // слизаме едно ниво надолу
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
        
        public void Inorder()
        {
            Inorder(ReturnRoot());
        }

        private void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root._leftLeaf);
                Console.WriteLine(root._data + "  " + root._name);
                Inorder(root._rigthLeaf);
            }
        }
    }
}
