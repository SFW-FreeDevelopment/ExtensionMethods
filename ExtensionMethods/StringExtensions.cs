namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsNotNullOrEmpty(this string value)
        {
            return value != null && value != string.Empty;
        }
    }
}