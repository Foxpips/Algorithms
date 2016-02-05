namespace OperationMicrosoft.DataStructures.Makers
{
    public class BinaryTreeMaker<TValue> : TreeMakerBase<TValue>
    {
        public TreeNode<TValue> Create(TValue[] values, int index = 0)
        {
            var current = new TreeNode<TValue> { Value = values[index] };
            
            var currentIndex = index * 2;
            if (currentIndex + 1 < values.Length)
            {
                current.Left = Create(values, currentIndex + 1);
            }

            if (currentIndex + 2 < values.Length)
            {
                current.Right = Create(values, currentIndex + 2);
            }
            return current;
        }
    }
}