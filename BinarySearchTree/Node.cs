using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public Node leftChild;
        public int data;
        public Node rightChild;

        public Node(int data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }
    }
}
