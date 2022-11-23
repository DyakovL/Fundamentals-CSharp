using System.Collections.Generic;

namespace CoffeeLover
{
    internal static class ExtensionsHelpers
    {
        public static void Swap<T>(this List<T> list,
                                   int i,
                                   int j) => (list[i], list[j]) = (list[j], list[i]);
    }
}