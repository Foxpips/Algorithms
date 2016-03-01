using System;

namespace OperationMicrosoft.Algorithms.ReverseByte
{
    public class ByteReverser
    {
        public static byte ReverseByte(byte val)
        {
            byte result = 0;
            var counter = Convert.ToString(val, 2).Length;

            while (counter-- > 0)
            {
                result <<= 1;
                result |= (byte)(val & 1);
                val = (byte)(val >> 1);
            }

            return result;
        }

        public static string ConvertToBinary(int n)
        {
            return (n < 2) ? n.ToString() : ConvertToBinary(n / 2) + n % 2;
        }
    }
}