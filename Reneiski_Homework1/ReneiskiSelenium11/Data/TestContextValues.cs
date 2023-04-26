using NUnit.Framework;

namespace ReneiskiSelenium11.Data
{
    public class TestContextValues
    {
        public static string ExecutableClassName => TestContext.CurrentContext.Test.ClassName;
    }
}
