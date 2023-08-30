using Microsoft.Extensions.Configuration;
using ReneiskiSelenium11.Data.Enums;

namespace ReneiskiSelenium11.Data
{
    public class TestSettings
    {
        public static Browsers Browser { get; set; }
        public static string PageUrl { get; set; }

        static IConfiguration TestConfiguration { get; } = new ConfigurationBuilder().AddJsonFile("testsettings.json").Build();

        static TestSettings()
        {
            Enum.TryParse(TestConfiguration["Common:Browser"], out Browsers browser);
            Browser = browser;
            PageUrl = TestConfiguration["Common:Urls:Page"];
        }
    }
}
