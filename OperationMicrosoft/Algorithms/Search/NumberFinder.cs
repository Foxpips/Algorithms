using System;

namespace OperationMicrosoft.Algorithms.Search
{
    internal class NumberFinder
    {
        internal static void GetSmallest(string input, int amountToRemove)
        {
            Action<string> print = Console.WriteLine;
            var res = BuildLowestNumberRec(input, amountToRemove);
            print(res);
        }

        private static string BuildLowestNumberRec(string input, int amountToRemove, string res = "")
        {
            var minIndex = 0;
            var inputLength = input.Length;

            if (amountToRemove == 0)
            {
                res += input;
                return res;
            }

            if (inputLength <= amountToRemove)
            {
                return res;
            }

            for (var i = 1; i <= amountToRemove; i++)
            {
                if (input[i] < input[minIndex])
                {
                    minIndex = i;
                }
            }

            res += (input[minIndex]);

            var newStr = input.Substring(minIndex + 1, inputLength - (minIndex + 1));
            return BuildLowestNumberRec(newStr, amountToRemove - minIndex, res);
        }
    }
}