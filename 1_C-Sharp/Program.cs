using System;
using _1_C_Sharp.Tree;

namespace _1_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(5);
            BinaryTree tree = new BinaryTree();
            tree.InsertNode(root, 3);
            tree.InsertNode(root, 2);
            tree.InsertNode(root, 4);
            tree.InsertNode(root, 7);
            tree.InsertNode(root, 6);
            tree.InsertNode(root, 8);
            tree.Print(root);
        }
    }
}
