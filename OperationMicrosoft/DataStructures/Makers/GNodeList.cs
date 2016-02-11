using System;
using OperationMicrosoft.DataStructures.Objects;

namespace OperationMicrosoft.DataStructures.Makers
{
    public class GNodeList<TNodeType>
    {
        public ListNode<TNodeType> Head { get; set; }
        public ListNode<TNodeType> CurrentNode { get; set; }
        public int ListSize { get; set; }

        private void InitialiseHead(ListNode<TNodeType> newNode)
        {
            Head = Head ?? newNode;
            CurrentNode = CurrentNode ?? Head;
        }

        private void IterateAllNodes(Action<ListNode<TNodeType>> work)
        {
            var startingNode = Head;
            while (startingNode != null)
            {
                work(startingNode);
                startingNode = startingNode.Next;
            }
        }

        public void Add(ListNode<TNodeType> newNode)
        {
            InitialiseHead(newNode);
            CurrentNode.Next = newNode;
            CurrentNode = newNode;
            ListSize++;
        }

        public void AddAfter(object i, ListNode<TNodeType> itemToAdd)
        {
            var currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(i))
                {
                    var nextNode = currentNode.Next;
                    currentNode.Next = itemToAdd;
                    itemToAdd.Next = nextNode;
                    return;
                }
                currentNode = currentNode.Next;
            }
        }

        public void Remove(object itemToRemove)
        {
            ListNode<TNodeType> previousNode = null;

            IterateAllNodes(startingNode =>
            {
                if (startingNode.Value.Equals(itemToRemove))
                {
                    ListSize--;
                    if (previousNode != null)
                    {
                        previousNode.Next = startingNode.Next;
                    }
                    else
                    {
                        Head = Head.Next;
                    }
                }
                previousNode = startingNode;
            });
        }

        public bool Find(object o)
        {
            bool found = false;

            IterateAllNodes(startNode =>
            {
                if (startNode.Value.Equals(o))
                {
                    found = true;
                }
            });
            return found;
        }

        public void Traverse()
        {
            Console.WriteLine("Traversing");

            IterateAllNodes(startNode => Console.WriteLine(startNode.Value));
        }

        public void Reverse()
        {
            Console.WriteLine("Reversing");
            var currentNode = Head;
            ListNode<TNodeType> previousNode = null;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next;
                currentNode.Next = previousNode;

                previousNode = currentNode;
                currentNode = nextNode;
            }
            Head = previousNode;
        }
    }
}