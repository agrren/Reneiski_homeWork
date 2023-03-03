using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ReneiskiSelenium11.Tests
{
    public class BaseTest
    {
        protected IWebDriver _driver;
        protected WebDriverWait _driverWait;
        protected Actions _driverActions;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            _driverActions = new Actions(_driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
