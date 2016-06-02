using System;
using NUnit.Framework;
using OperationMicrosoft.Algorithms.ReverseByte;

namespace OperationMicrosoft.Tests
{
    public class ReverseByteTests
    {
        private const byte Test = 140;

        [Test]
        public void Reverse_Number_Byte()
        {
            Action<string> print = x => Console.WriteLine(x.PadLeft(8, '0'));
            
            print(ByteReverser.ConvertToBinary(Test));
            var reverseByte = ByteReverser.ReverseByte(Test);
            print(ByteReverser.ConvertToBinary(reverseByte));
        }

        [Test]
        public void Move_ByteOfZero_Right()
        {
            byte b = 1;

            b >>= 1;
            b >>= 1;

            Console.WriteLine(b);
        }

        [Test]
        public void ToBinary_Scenario_Result()
        {
            var binary = ByteReverser.ConvertToBinary(6);
            Console.WriteLine(binary);
        }
    }
}