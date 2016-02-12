using System;
using NUnit.Framework;
using OperationMicrosoft.Algorithms.Search;
using OperationMicrosoft.DataStructures.Makers;
using OperationMicrosoft.DataStructures.Objects;

namespace OperationMicrosoft.Tests
{
    public class BinaryTreeTests
    {
        private TreeNode<string> _root;
        private readonly TreeSearcher<string> _treeSearcher = new TreeSearcher<string>();

        [SetUp]
        public void SetUp()
        {
            var binaryTreeMaker = new BinaryTreeMaker<string>(new[] {"F", "D", "H", "B", "E", "G", "I", "A", "C"});
            var binaryTreeMaker2 = new BinaryTreeMaker<int>(new[] {1,2,3});
            _root = binaryTreeMaker.Root;
        }

        //             F    
        //           /   \ 
        //          D     H
        //         / \   / \
        //        B   E G   I
        //       / \
        //      A   C
        //         / \
        //      (CL) (CR)
        //

        [Test]
        public void InOrder_Search()
        {
            _treeSearcher.InOrderSearch(_root);
            var enumerator = _treeSearcher.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Value);
            }
        }

        [Test]
        public void Pre_Order_Search()
        {
            _treeSearcher.PreOrderSearch(_root);
        }

        [Test]
        public void Post_Order_Search()
        {
            _treeSearcher.PostOrderSearch(_root);
        }

        [Test]
        public void InOrder_Search_UnevenTree()
        {
            _root.Left.Left.Right.Left = new TreeNode<string>("CL");
            _root.Left.Left.Right.Right = new TreeNode<string>("CR");
            _treeSearcher.InOrderSearch(_root);
        }

        [Test]
        public void PostOrder_Search_UnevenTree()
        {
            _root.Left.Left.Right.Left = new TreeNode<string>("CL");
            _root.Left.Left.Right.Right = new TreeNode<string>("CR");
            _treeSearcher.PostOrderSearch(_root);
        }
    }
}