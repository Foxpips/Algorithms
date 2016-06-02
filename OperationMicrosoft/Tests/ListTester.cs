using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace OperationMicrosoft.Tests
{
    public class ListTester
    {
        [Test]
        public void Method_Scenario_Result()
        {
            var peopleList = GetPeople();

            var collection = default(ICollection<Person>);

            var foo = ((IList<Person>) peopleList);

            foreach (var person in foo)
            {
                Console.WriteLine(person.Name);
            }
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = new Person {Name = "Simon"};
            IEnumerable<Person> asEnumerable = new List<Person> {people}.AsEnumerable();

            return asEnumerable;
        }
    }
}