using System;
using System.Collections;
using System.Collections.Generic;
using OperationMicrosoft.DataStructures.Objects.Nodes;

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

        internal void PreOrderSearch(TreeNode<TType> currentNode)
        {
            if (currentNode == null)
            {
                return;
            }

            PrintAndAddToList(currentNode);
            PreOrderSearch(currentNode.Left);
            PreOrderSearch(currentNode.Right);
        }

        internal void InOrderSearch(TreeNode<TType> currentNode)
        {
            if (currentNode == null)
            {
                return;
            }

            InOrderSearch(currentNode.Left);
            PrintAndAddToList(currentNode);
            InOrderSearch(currentNode.Right);
        }

        internal void PostOrderSearch(TreeNode<TType> currentNode)
        {
            if (currentNode == null)
            {
                return;
            }

            PostOrderSearch(currentNode.Left);
            PostOrderSearch(currentNode.Right);
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