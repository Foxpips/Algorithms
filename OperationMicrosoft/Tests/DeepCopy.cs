using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NUnit.Framework;

namespace OperationMicrosoft.Tests
{
    public class DeepCopy
    {
        private static T DeepCopyCreate<T>(T obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Position = 0;

                return (T) formatter.Deserialize(stream);
            }
        }

        [Test]
        public void Method_Scenario_Result()
        {
            var emily = new Person {Name = "Emily"};
            Person bronteClone = DeepCopyCreate(emily);
            emily.Name = "Joe";
            Console.WriteLine(bronteClone.Name);
        }
    }

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
    }
}