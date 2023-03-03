using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace ReneiskiSelenium11.Utilities
{
    public class Utility
    {
        protected IWebDriver _driver;
        protected WebDriverWait _driverWait;
        protected Actions _driverActions;

        public Utility(IWebDriver webDriver)
        {
            _driver = webDriver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            _driverActions = new Actions(_driver);
        }

        public IWebElement FindElementByXPathId(string value)
        {
            string xPath = string.Format("//*[@id='{0}']", value);
            var element = _driverWait.Until(drv => drv.FindElement(By.XPath(xPath)));
            return element;
        }

        public IWebElement FindElementByXPathClass(string value)
        {
            string xPath = string.Format("//*[@class='{0}']", value);
            var element = _driverWait.Until(drv => drv.FindElement(By.XPath(xPath)));
            return element;
        }

        public void ClickButton(string value)
        {
            var elem = FindElementByXPathId(value);
            switch (value)
            {
                case "doubleClickBtn":
                    _driverActions.DoubleClick(elem).Perform();
                    break;
                case "rightClickBtn":
                    _driverActions.ContextClick(elem).Perform();
                    break;
            }
        }

        public string TextResult(string value)
        {
            var elem = FindElementByXPathId(value);
            return elem.Text;
        }

        public void ClickBtn(string value) => FindElementByXPathId(value).Click();
    }
}
