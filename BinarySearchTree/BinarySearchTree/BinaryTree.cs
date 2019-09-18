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
                            return;
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
                            return;
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
                if(input < current.data)
                {
                    if(current.left != null)
                    {
                        current = current.left;
                        Console.WriteLine("test left");
                        if (current.data == input)
                        {
                            Console.WriteLine("Item found");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("test item not found");
                        break;
                    }
                }
            }

            //while (true)
            //{
            //    if (root.data != input)
            //    {
            //        Console.WriteLine("Unable to locate item or item does not exist.");
            //        return;
            //    }
            //    else if (root.data == input)
            //    {
            //        Console.WriteLine("Item found.");
            //        return;
            //    }
            //    else if (root.data <= input)
            //    {
            //        root.left = root;
            //        Console.WriteLine("aaaa");
            //        return;
            //    }
            //    else if (root.data > input)
            //    {
            //        root.right = root;
            //        Console.WriteLine("bbbb");
            //        return;
            //    }
            //}
        }
    }

}
