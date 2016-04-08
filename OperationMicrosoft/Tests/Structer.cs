using System;
using System.Drawing;
using System.Drawing.Imaging;
using NUnit.Framework;

namespace OperationMicrosoft.Tests
{
    public abstract class TestConsts
    {
        public const string HelpMe = "Helpme";
    }

    public class DoStuffWithConsts
    {
        [Test]
        public void Const_Accessor_Result()
        {
            Console.WriteLine(TestConsts.HelpMe);
        }
    }

    public struct Structer
    {
        public readonly int U;
        private readonly int _u2;
        public int U3 { get; set; }

        public int U2
        {
            get { return _u2; }
        }

        public Structer(int u) : this()
        {
            U = u;
            _u2 = u;
        }
    }

    internal class X
    {
        protected virtual void F()
        {
            Console.WriteLine("X.F");
        }

        protected virtual void F2()
        {
            Console.WriteLine("X.F2");
        }
    }

    internal class Y : X
    {
        protected override sealed void F()
        {
            Console.WriteLine("Y.F");
        }

        protected override void F2()
        {
            Console.WriteLine("Y.F2");
        }
    }

    internal class Z : Y
    {
        // Attempting to override F causes compiler error CS0239. 
//         protected override void F() { Console.WriteLine("C.F"); }

        // Overriding F2 is allowed. 
        protected override void F2()
        {
            Console.WriteLine("Z.F2");
        }
    }


    public class TestStruct
    {
        [Test]
        [Ignore]
        public void TestTiffFiles_MultiPage_Result()
        {
            var image = Image.FromFile(@"C:\Users\SimonMarkey\Desktop\b8d7ca71-026b-4f1c-92c8-538e046109f3ExtendDigitalClaim.tiff");
            var pages = image.GetFrameCount(FrameDimension.Page);
        }

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