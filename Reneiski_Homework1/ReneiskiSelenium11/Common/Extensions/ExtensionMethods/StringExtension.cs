namespace ReneiskiSelenium11.Common.Extensions.ExtensionMethods
{
    public static class StringExtension
    {
        public static string ProcessStringBackspaces(this string value) => value.Trim().Replace("\r\n", string.Empty);
    }
}
