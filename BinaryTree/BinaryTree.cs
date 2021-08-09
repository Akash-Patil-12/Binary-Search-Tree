using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinaryTree 
    {
        private Node<int> _root;
        public BinaryTree()
        {
            _root = null;
        }
        public void Insert(int data)
        {
            if (_root == null)
            {
                _root = new Node<int>(data);
                return;
            }
            InsertRec(_root, new Node<int>(data));
        }
        private void InsertRec(Node<int> root, Node<int> newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data.CompareTo(root.Data)<0)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);
            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private void DisplayTree(Node<int> root)
        {
            if (root == null) return;
            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}
