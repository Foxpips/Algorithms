namespace OperationMicrosoft.DataStructures
{
    public class TreeNode<TValue>
    {
        public TValue Value { get; internal set; }
        public TreeNode<TValue> Left { get; internal set; }
        public TreeNode<TValue> Right { get; internal set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}