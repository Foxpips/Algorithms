namespace OperationMicrosoft.DataStructures.Objects
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