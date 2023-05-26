using NUnit.Framework;
using ReneiskiSelenium11.Common.Drivers;
using ReneiskiSelenium11.Data;
using ReneiskiSelenium11.PageObjects;

namespace ReneiskiSelenium11.Tests
{
    public class BaseTest
    {
        public BaseTest()
        {
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            WebDriverFactory.InitializeDriver();
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.PageUrl);
            GenericPages.BasePage.GoToElemntsPage();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriverFactory.QuitDriver();
        }
    }
}
