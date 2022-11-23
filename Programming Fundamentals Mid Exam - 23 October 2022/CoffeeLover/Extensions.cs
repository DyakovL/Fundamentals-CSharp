using System.Collections.Generic;

namespace CoffeeLover
{
    internal partial class Program
    {
        public static class Extensions
        {
            public static void Swap<T>(this List<T> list, int i, int j)
            {
                (list[i], list[j]) = (list[j], list[i]);
            }
        }
    }
}
