using ReneiskiSelenium11.Common.Drivers;
using ReneiskiSelenium11.Data;

namespace ReneiskiSelenium11.PageObjects
{
    public class BasePage : WebDriverFactory
    {
        public void GoToHomePage() => WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.PageUrl);
    }
}
