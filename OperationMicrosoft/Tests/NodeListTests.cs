using System;
using NUnit.Framework;
using OperationMicrosoft.DataStructures.Makers;
using OperationMicrosoft.DataStructures.Objects.Nodes;

namespace OperationMicrosoft.Tests
{
    public class NodeListTests
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            var nodeList = new LinkedList<object>();
            nodeList.Add(new ListNode<object>(1));
            nodeList.Add(new ListNode<object>(2));
            nodeList.Add(new ListNode<object>(3));
            nodeList.Add(new ListNode<object>(4));
            nodeList.Add(new ListNode<object>(5));
            nodeList.Add(new ListNode<object>(6));
            nodeList.Add(new ListNode<object>("d"));
            nodeList.Add(new ListNode<object>("g"));
            nodeList.AddAfter(3, new ListNode<object>("B"));
            nodeList.AddAfter("g", new ListNode<object>("uber"));

            Console.WriteLine(nodeList.Tail);


            Console.WriteLine("The list has {0} elements!", nodeList.ListSize);
            nodeList.Traverse();
            nodeList.Reverse();
            nodeList.Traverse();

            Assert.That(nodeList.ListSize, Is.EqualTo(10));
            Assert.That(nodeList.Contains("g"), Is.True);

            nodeList.Remove("d");
            nodeList.Remove("g");

            Assert.That(nodeList.ListSize, Is.EqualTo(8));
            Assert.That(nodeList.Contains("g"), Is.False);

            nodeList.Reverse();
            nodeList.Traverse();
        }
    }
}