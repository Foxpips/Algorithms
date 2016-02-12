using System;
using OperationMicrosoft.DataStructures.Objects;

namespace OperationMicrosoft.DataStructures.Makers
{
    public class LinkedList<TValue>
    {
        public ListNode<TValue> Head { get; private set; }
        public ListNode<TValue> Tail { get; private set; }
        public int ListSize { get; set; }

        private void IterateAllNodes(Action<ListNode<TValue>, ListNode<TValue>> work)
        {
            var currentNode = Head;
            ListNode<TValue> previousNode = null;
            while (currentNode != null)
            {
                work(currentNode, previousNode);
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public void Add(ListNode<TValue> newNode)
        {
            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }

            ListSize++;
        }

        public void AddAfter(TValue value, ListNode<TValue> itemToAdd)
        {
            var currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    ListSize++;
                    var nextNode = currentNode.Next;
                    currentNode.Next = itemToAdd;
                    itemToAdd.Next = nextNode;

                    if (currentNode.Equals(Tail))
                    {
                        Tail = itemToAdd;
                    }
                }
                currentNode = currentNode.Next;
            }
        }

        public void Remove(TValue itemToRemove)
        {
            if (Head.Value.Equals(itemToRemove))
            {
                ListSize--;
                Head = Head.Next;
            }
            else
            {
                IterateAllNodes((current, previous) =>
                {
                    if (current.Value.Equals(itemToRemove))
                    {
                        ListSize--;
                        previous.Next = current.Next;
                    }
                });
            }
        }

        public bool Contains(TValue o)
        {
            var found = false;

            IterateAllNodes((current, previous) =>
            {
                if (current.Value.Equals(o))
                {
                    found = true;
                }
            });

            return found;
        }

        public void Reverse()
        {
            Console.WriteLine("Reversing");
            var currentNode = Head;
            ListNode<TValue> previousNode = null;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next;
                currentNode.Next = previousNode;

                previousNode = currentNode;
                currentNode = nextNode;
            }

            Head = previousNode;
        }

        public void Traverse()
        {
            Console.WriteLine("Traversing");
            IterateAllNodes((current, previous) => Console.WriteLine(current.Value));
        }
    }
}