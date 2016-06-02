using System;
using NUnit.Framework;

namespace OperationMicrosoft.Tests
{
    public class EnumTester
    {
        private enum Suits
        {
            Spades = 1,
            Clubs = 2,
            Diamonds = 4,
            Hearts = 8
        }

        [Flags]
        private enum SuitsFlags
        {
            Spades = 1,
            Clubs = 2,
            Diamonds = 4,
            Hearts = 8
        }

        
        private enum ApplicationTypesEnum
        {
            Ppsn =1,
            Ppsc =2,
            TwoForOne=3
        }

        [Test]
        public void Method_Scenario_Result()
        {
            var applicationTypesEnum = (ApplicationTypesEnum.Ppsc | ApplicationTypesEnum.Ppsn);
            Console.WriteLine(applicationTypesEnum);

            var applicationTypesEnum2 = (ApplicationTypesEnum.Ppsc | ApplicationTypesEnum.TwoForOne);


            if (applicationTypesEnum2.Equals(ApplicationTypesEnum.Ppsc))
            {
                Console.WriteLine("True");
            }
            Console.WriteLine(applicationTypesEnum2);
        }


        //        [Test]
        //        public void Method2_Scenario_Result()
        //        {
        //            var str1 = (Suits.Spades | Suits.Diamonds).ToString();
        //            // "5"
        //            var str2 = (SuitsFlags.Spades | SuitsFlags.Diamonds).ToString();
        //            // "Spades, Diamonds"  
        //
        //            Console.WriteLine(str1);
        //            Console.WriteLine(str2);
        //        }
    }
}