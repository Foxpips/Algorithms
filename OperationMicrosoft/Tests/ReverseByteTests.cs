using System;
using Microsoft.Office.Interop.Word;
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


        [Test][Ignore]
        public void ConvertWord_To_Pdf()
        {
            var appWord = new Application();
            var wordDocument = appWord.Documents.Open(@"C:\Users\SimonMarkey\Desktop\TestWord2.docx");
            wordDocument.ExportAsFixedFormat(@"C:\Users\SimonMarkey\Desktop\TestWord.pdf", WdExportFormat.wdExportFormatPDF);
            wordDocument.Close();
            appWord.Quit();
        }


        [Test]
        public void Method_Compare_Result()
        {
           Action<object> print = Console.WriteLine;

            print(string.Compare(".docx", ".doc", StringComparison.OrdinalIgnoreCase));
            print(string.Compare(".doc", ".doc", StringComparison.OrdinalIgnoreCase));
            print(string.Compare(".DOC", ".doc", StringComparison.OrdinalIgnoreCase));
        }
    }
}