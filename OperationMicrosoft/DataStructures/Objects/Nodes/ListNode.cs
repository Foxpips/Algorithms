namespace OperationMicrosoft.DataStructures.Objects.Nodes
{
    public class ListNode<TValue>
    {
        public ListNode(TValue nodeValue)
        {
            Value = nodeValue;
            Next = null;
        }

        public TValue Value { get; set; }
        public ListNode<TValue> Next { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}