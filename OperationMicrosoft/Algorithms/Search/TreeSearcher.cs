using System;
using System.Collections;
using System.Collections.Generic;
using OperationMicrosoft.DataStructures.Objects;

namespace OperationMicrosoft.Algorithms.Search
{
    internal class TreeSearcher<TType> : IEnumerable<TreeNode<TType>>
    {
        public List<TreeNode<TType>> SortedNodes { private set; get; }

        public TreeSearcher()
        {
            SortedNodes = new List<TreeNode<TType>>();
        }

        public TType this[int i]
        {
            get
            {
                try
                {
                    return SortedNodes[i].Value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Index out of range!");
                    throw;
                }
            }
        }

        internal void PreOrderSearch(TreeNode<TType> root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Value);
            PreOrderSearch(root.Left);
            PreOrderSearch(root.Right);
        }

        internal void InOrderSearch(TreeNode<TType> root)
        {
            TraverseInOrder(root);
        }

        public void PostOrderSearch(TreeNode<TType> root)
        {
            TraversePostOrder(root);
        }

        internal void TraverseInOrder(TreeNode<TType> currentNode)
        {
            if (currentNode.Left != null) TraverseInOrder(currentNode.Left);
            PrintAndAddToList(currentNode);
            if (currentNode.Right != null) TraverseInOrder(currentNode.Right);
        }

        internal void TraversePostOrder(TreeNode<TType> currentNode)
        {
            if (currentNode.Left != null) TraversePostOrder(currentNode.Left);
            if (currentNode.Right != null) TraversePostOrder(currentNode.Right);
            PrintAndAddToList(currentNode);
        }

        private void PrintAndAddToList(TreeNode<TType> node)
        {
            Console.WriteLine(node.Value);
            SortedNodes.Add(node);
        }

        public IEnumerator<TreeNode<TType>> GetEnumerator()
        {
            return SortedNodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}