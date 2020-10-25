using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            ///creating head node by parameterised constructor
            BinaryTree<int> binaryTree = new BinaryTree<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            ///Displaying binary tree
            binaryTree.Display();

        }
    }
}
