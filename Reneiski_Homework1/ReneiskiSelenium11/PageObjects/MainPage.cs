using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;
using ReneiskiSelenium11.PageObjects.Modules;

namespace ReneiskiSelenium11.PageObjects
{
    public class MainPage : BasePage
    {
        public LeftMenuNavigationPanel LeftMenuNavigationPanel => new LeftMenuNavigationPanel();

        private MyWebElement elementsByXPath = new MyWebElement(By.XPath("//*[@class='card-body']//*[contains(text(), 'Elements')]"));

        public void GoToElemntsPage() => elementsByXPath.Click();
    }
}
