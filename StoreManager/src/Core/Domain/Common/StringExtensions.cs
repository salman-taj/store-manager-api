namespace StoreManager.Domain.Common
{
    public static class StringExtensions
    {
        public static string NullToString(this object Value)
        {
            return Value == null ? string.Empty : Value.ToString();
        }
    }
}