using OpenQA.Selenium;
using ReneiskiSelenium11.Utilities;

namespace ReneiskiSelenium11.PageObjects
{
    public class BasePage : Utility
    {
        public BasePage(IWebDriver _driver) : base(_driver)
        {
        }

        public string GetPageUrl(string pageUrl)
        {
            string url = string.Format("https://demoqa.com/{0}", pageUrl);
            return url;
        }

        public void GoToPage(string url) => _driver.Navigate().GoToUrl(GetPageUrl(url));
    }
}
