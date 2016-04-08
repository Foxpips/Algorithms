using System.Collections.Generic;
using OperationMicrosoft.DataStructures.Objects.Nodes;

namespace OperationMicrosoft.DataStructures.Makers
{
    public class BinaryTreeMaker<TValue>
    {
        public TreeNode<TValue> Root { get; protected set; }

        public BinaryTreeMaker(IReadOnlyList<TValue> values, int index = 0)
        {
            Create(values, index);
        }

        private TreeNode<TValue> Create(IReadOnlyList<TValue> values, int index)
        {
            var current = new TreeNode<TValue>(values[index]);

            if (index == 0)
            {
                Root = current;
            }

            var currentIndex = index * 2;
            if (currentIndex + 1 < values.Count)
            {
                current.Left = Create(values, currentIndex + 1);
            }

            if (currentIndex + 2 < values.Count)
            {
                current.Right = Create(values, currentIndex + 2);
            }
            return current;
        }
    }
}