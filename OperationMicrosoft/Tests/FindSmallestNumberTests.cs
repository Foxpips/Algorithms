using NUnit.Framework;
using OperationMicrosoft.Algorithms.Search;

namespace OperationMicrosoft.Tests
{
    public class FindSmallestNumberTests
    {
        [Test]
        public void MainTest()
        {
            NumberFinder.GetSmallest("28971", 4); //271
            NumberFinder.GetSmallest("237489", 3); //234
            NumberFinder.GetSmallest("9438958", 4); //358
            NumberFinder.GetSmallest("18437562", 5); //132
            NumberFinder.GetSmallest("18437562", 3); //13562
            NumberFinder.GetSmallest("18437562", 2); //137562
            NumberFinder.GetSmallest("18437562", 1); //1437562
            NumberFinder.GetSmallest("54321", 4); //1437562
        }
    }
}