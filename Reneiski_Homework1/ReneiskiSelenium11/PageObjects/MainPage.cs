using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;
using ReneiskiSelenium11.PageObjects.Modules;

namespace ReneiskiSelenium11.PageObjects
{
    public class MainPage : BasePage
    {
        private MyWebElement ElementsMenuButton = new MyWebElement(By.XPath("//*[@class='card-body']//*[contains(text(), 'Elements')]"));

        public LeftMenuNavigationPanel LeftMenuNavigationPanel => new LeftMenuNavigationPanel();

        public void GoToElementsPage() => ElementsMenuButton.Click();
    }
}
