using NUnit.Framework;
using ReneiskiSelenium11.Common.Drivers;
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
            GenericPages.BasePage.GoToHomePage();
            GenericPages.MainPage.GoToElemntsPage();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriverFactory.QuitDriver();
        }
    }
}
