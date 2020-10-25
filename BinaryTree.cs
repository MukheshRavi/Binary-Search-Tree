using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        public T nodeData { get; set; }
        public BinaryTree<T> leftTree { get; set; }
        public BinaryTree<T> rightTree { get; set; }
        public static int leftCount;
        public static int rightCount;
        /// <summary>
        /// Parameterised constructor
        /// </summary>
        /// <param name="nodeData"></param>
        public BinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        /// <summary>
        /// UC1
        /// Inserts node 
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T parentValue = this.nodeData;
            int value = parentValue.CompareTo(item);
            ///if entered new node data is less than parent data then it will be added to left
            if ((parentValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                    this.leftTree.Insert(item);
            }

            else
            {
                ///if entered new node data is more than parent data then it will be added to right
                if (this.rightTree == null)
                {
                    this.rightTree = new BinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                {
                    this.rightTree.Insert(item);
                }

            }
        }
        /// <summary>
        /// Displaying binary search tree in Inorder
        /// leftchild-parent-Rightchild
        /// </summary>
        public void Display()
        {
            if (this.leftTree != null)
            {
                leftCount++;
                ///Iterates to last left node and display node
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                rightCount++;
                this.rightTree.Display();
            }

        }
        /// <summary>
        /// This method returns the size of tree
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + leftCount + rightCount));
        }
    }
}
