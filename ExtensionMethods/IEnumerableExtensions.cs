using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty(this IEnumerable<object> value)
        {
            return value == null || !value.Any();
        }
    }
}