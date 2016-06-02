using System;
using Microsoft.Office.Interop.Word;
using NUnit.Framework;

namespace OperationMicrosoft.Tests
{
    public class WordDocTests
    {
        [Test]
        [Ignore]
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