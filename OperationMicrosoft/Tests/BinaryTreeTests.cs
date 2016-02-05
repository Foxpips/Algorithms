using NUnit.Framework;
using OperationMicrosoft.DataStructures;
using OperationMicrosoft.DataStructures.Makers;

namespace OperationMicrosoft.Tests
{
    public class BinaryTreeTests
    {
        //            CreateTree(1, 2, 3, 4, 5, 6, 7, 8);
        //             1
        //           /   \
        //          2     3
        //         / \   / \
        //        4   5 6   7
        //       /
        //      8

        [Test]
        public void Create_Binary_Tree()
        {
            int[] values = {1, 2, 3, 4, 5, 6, 7, 8};
            var tree = new BinaryTreeMaker<int>().Create(values);
        }
    }
}