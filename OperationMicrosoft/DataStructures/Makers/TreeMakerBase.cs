using OperationMicrosoft.DataStructures.Objects;

namespace OperationMicrosoft.DataStructures.Makers
{
    public abstract class TreeMakerBase<TValue>
    {
        public TreeNode<TValue> Root { get; protected set; }
    }
}