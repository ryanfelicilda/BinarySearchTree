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
                            current.left = node;
                            break;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                    if (node.data > current.data)
                    {
                        if (current.right == null)
                        {
                            current.right = node;
                            break;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                }
            }
        }
        public void Search(int input)
        {
            Node current = root;
            while(current != null)
            {
                if(input <= current.data)
                {
                    if(current.left != null)
                    {
                        current = current.left;
                        if (current.data == input)
                        {
                            Console.WriteLine($"{input} has been found.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{input} not found or does not exist.");
                        break;
                    }
                }
                if (input > current.data)
                {
                    if (current.right != null)
                    {
                        current = current.right;
                        if (current.data == input)
                        {
                            Console.WriteLine($"{input} has been found.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{input} not found or does not exist.");
                        break;
                    }
                }
            }

        }
    }

}
