using System;
using NUnit.Framework;

namespace OperationMicrosoft.Tests
{
    public struct Structer
    {
        public readonly int U;
        private readonly int _u2;
        public int U3 { get; set; }

        public int U2
        {
            get
            {
                return _u2;
            }
        }

        public Structer(int u) : this()
        {
            U = u;
            _u2 = u;
        }
    }

    class X
    {
        protected virtual void F() { Console.WriteLine("X.F"); }
        protected virtual void F2() { Console.WriteLine("X.F2"); }
    }
    class Y : X
    {
        sealed protected override void F() { Console.WriteLine("Y.F"); }
        protected override void F2() { Console.WriteLine("Y.F2"); }
    }
    class Z : Y
    {
        // Attempting to override F causes compiler error CS0239. 
//         protected override void F() { Console.WriteLine("C.F"); }

        // Overriding F2 is allowed. 
        protected override void F2() { Console.WriteLine("Z.F2"); }
    }


    public class TestStruct
    {
        [Test]
        public void Method_Scenario_Result()
        {
            var structer = new Structer(10);

            Console.WriteLine(structer.U);
            Console.WriteLine(structer.U2);
            Console.WriteLine(structer.U3);

//            structer.U = 12;
//            structer.U2 = 12;
//            structer.U3 = 12;
        }
    }
}