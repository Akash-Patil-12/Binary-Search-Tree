using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node<int> root = new Node<int>();
            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);
            tree.DisplayTree();

        }
    }
}
