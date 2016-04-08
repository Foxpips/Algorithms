namespace OperationMicrosoft.Tests
{
    public abstract class TestAbstract
    {
        public abstract void Save();
    }


    public class TestDerived : TestAbstract
    {
        public override void Save()
        {
        }
    }


    public struct SuperStruct
    {
        private int _i;
//        private int _ix { get; set; }

        public SuperStruct(int x)
        {
//            _ix = 10;
            _i = x;
        }
    }
}