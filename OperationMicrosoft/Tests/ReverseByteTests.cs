using System;
using NUnit.Framework;
using OperationMicrosoft.Algorithms.ReverseByte;

namespace OperationMicrosoft.Tests
{
    public class ReverseByteTests
    {
        [Test]
        public void Reverse_Number_Byte()
        {
            byte test = 140;
            var reverseByte = ByteReverser.ReverseByte(test);

            var binary1 = ByteReverser.ConvertToBinary(test);
            Console.WriteLine(binary1.PadLeft(8,'0'));

            var binary2 = ByteReverser.ConvertToBinary(reverseByte);
            Console.WriteLine(binary2.PadLeft(8,'0'));
        }

        [Test]
        public void ToBinary_Scenario_Result()
        {
            var binary = ByteReverser.ConvertToBinary(6);
            Console.WriteLine(binary);
        }
    }
}