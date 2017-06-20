using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class BinaryTree
    {
        private List<int> values = new List<int>();
        private Node root;

        public BinaryTree()
        {
            root = null;
        }
        public void CreateTree()
        {
            root = new BinarySearchTree.Node(15);
            root.leftChild = new Node(10);
            root.rightChild = new Node(25);
            root.leftChild.rightChild = new Node(13);
            root.leftChild.leftChild = new Node(8);
            root.rightChild.rightChild = new Node(38);
            root.rightChild.leftChild = new Node(20);
        }
        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }
        private void InOrder(Node node)
        {
            if(node == null)
            {
                return;
            }
            InOrder(node.leftChild);
            values.Add(node.data);
            InOrder(node.rightChild);
        }
        public void Search()
        {
            int searchedInt = UISearch();
            InOrder();
            foreach(int value in values)
            {
                if (searchedInt == value)
                {
                    Console.WriteLine("Value is in tree");
                    Console.ReadLine();
                }
            }
        }
        public void Add()
        {
            int valueToAdd = UIAddValue();
            Node toAdd = new Node(valueToAdd);
            Node current = root;
            Node parent = null;
            while (current != null)
            {
                if(current.data == valueToAdd)
                {
                    return;
                }
                else if (current.data > valueToAdd)
                {
                    parent = current;
                    current = current.leftChild;
                }
                else if (current.data < valueToAdd)
                {
                    parent = current;
                    current = current.rightChild;
                }
            }
            if (parent == null)
            {
                root = toAdd;
            }
            else
            {
                if (parent.data > valueToAdd)
                {
                    parent.leftChild = toAdd;
                }
                else
                {
                    parent.rightChild = toAdd;
                }
            }
            


        }
        private static int UISearch()
        {
            Console.WriteLine("What Value are you looking for");
            return int.Parse(Console.ReadLine());
        }
        private static int UIAddValue()
        {
            Console.WriteLine("What value do you want to add");
            return int.Parse(Console.ReadLine());
        }

    }
}
