using System.Collections.Generic;
using System.Linq;

namespace AquariumSimulation
{
    public static class EnumerableExtension
    {
        public static bool ContainsKey<T>(this IEnumerable<T> enumerable, in int index) =>
            index >= 0 && index < enumerable.Count();
    }
}
