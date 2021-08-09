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
            tree.Insert(22);
            tree.Insert(40);
            tree.Insert(11);
            tree.Insert(3);
            tree.Insert(16);
            tree.Insert(60);
            tree.Insert(95);
            tree.Insert(65);
            tree.Insert(63);
            tree.Insert(67);
            tree.DisplayTree();

        }
    }
}
