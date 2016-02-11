using System;
using NUnit.Framework;
using OperationMicrosoft.DataStructures.Makers;
using OperationMicrosoft.DataStructures.Objects;

namespace OperationMicrosoft.Tests
{
    public class NodeListTests
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            var sNodeList = new GNodeList<object>();
            sNodeList.Add(new ListNode<object>(1));
            sNodeList.Add(new ListNode<object>(2));
            sNodeList.Add(new ListNode<object>(3));
            sNodeList.Add(new ListNode<object>(4));
            sNodeList.Add(new ListNode<object>(5));
            sNodeList.Add(new ListNode<object>(6));
            sNodeList.Add(new ListNode<object>("d"));
            sNodeList.Add(new ListNode<object>("g"));
            sNodeList.AddAfter(3, new ListNode<object>("B"));

            Console.WriteLine("The list has {0} elements!", sNodeList.ListSize);
            sNodeList.Traverse();
            sNodeList.Reverse();
            sNodeList.Traverse();

            Assert.That(sNodeList.ListSize, Is.EqualTo(8));
            Assert.That(sNodeList.Find("g"), Is.True);

            sNodeList.Remove("d");
            sNodeList.Remove("g");

            Assert.That(sNodeList.ListSize, Is.EqualTo(6));
            Assert.That(sNodeList.Find("g"), Is.False);

            sNodeList.Reverse();
            sNodeList.Traverse();
        }
    }
}