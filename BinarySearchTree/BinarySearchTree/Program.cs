using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(7);
            tree.Add(3);
            tree.Add(20);
            tree.Add(27);
            tree.Search(1);
            tree.Search(3);
            tree.Search(33);
            tree.Search(27);
        }
    }
}
