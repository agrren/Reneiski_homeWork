namespace ReneiskiSelenium11.Common.Extensions.ExtensionMethods
{
    public static class ConvertText
    {
        public static string ConvertAnyText(string value) => value.Trim().Replace("\r\n", string.Empty);
    }
}
