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
            Node node = new Node(data);
            if(root == null)
            {
                root = new Node(data);
            }
            else
            {
                Node current = root;
                while (true)
                {
                    if(node.data <= current.data)
                    {
                        if(current.left == null)
                        {
                            current.left = new Node(data);
                            return;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                }
            }
        }
    }
}
