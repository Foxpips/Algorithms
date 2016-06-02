using NUnit.Framework;

namespace OperationMicrosoft.Tests
{
    public class ContraCoVariance
    {
        [Test]
        public void TestCova()
        {
            CreateSweets(new CharliesChocolateFactory());
        }

        public interface IChocolateFactory<out TType>
        {
            TType Create();
        }

        public class CharliesChocolateFactory : IChocolateFactory<MiniMarshMallow>
        {
            public MiniMarshMallow Create()
            {
                return new MiniMarshMallow();
            }
        }

        public void CreateSweets(IChocolateFactory<MarshMallow> factory)
        {
            factory.Create();
        }

        public class MarshMallow
        {
        }

        public class MiniMarshMallow : MarshMallow
        {
        }
    }
}