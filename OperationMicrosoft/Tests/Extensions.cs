using System;
using System.Collections.Generic;

namespace OperationMicrosoft.Tests
{
    public static class Extensions
    {
        public static void Each<TType>(this IEnumerable<TType> collection, Action<TType> work)
        {
            foreach (var item in collection)
            {
                work(item);
            }
        }
    }
}