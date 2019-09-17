using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Add(int data)
        {
            if(root == null)
            {
                root = new Node(data);
            }
            else
            {
            }
        }
    }
}
