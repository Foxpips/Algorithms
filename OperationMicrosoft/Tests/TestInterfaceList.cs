using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace OperationMicrosoft.Tests
{
    public class TestInterfaceList
    {
        [Test]
        public void Method_Scenario_Result()
        {
            var documents = new List<IDocument>()
            {
                new RestrictedDocument {Name = "Restricted"},
                new ScannedDocument {Name = "Scanned"}
            };


            foreach (var document in documents)
            {
                Console.WriteLine(document.Name);
                Console.WriteLine(document is ScannedDocument); 
            }
        }
    }

    public interface IDocument
    {
        string Name { get; set; }
    }

    public class ScannedDocument : IDocument
    {
        public string Name { get; set; }
    }

    public class RestrictedDocument : IDocument
    {
        public string Name { get; set; }
    }
}