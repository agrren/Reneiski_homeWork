using OpenQA.Selenium;
using ReneiskiSelenium11.Common.Drivers;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects
{
    public class BasePage : WebDriverFactory
    {
        private MyWebElement elementsByXPath = new MyWebElement(By.XPath("//*[@class=\"card-body\"]//*[contains(text(), 'Elements')]"));

        public void GoToElemntsPage() => elementsByXPath.Click();

        public string TextResult(string value)
        {
            var elem = MyWebElement.FindElementByXPathId(value);
            return elem.Text;
        }
    }
}
