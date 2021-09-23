using System.Collections;

namespace ExtensionMethods
{
    public static class ICollectionExtensions
    {
        public static bool IsNullOrEmpty(this ICollection value)
        {
            return value == null || value.Count == 0;
        }
    }
}