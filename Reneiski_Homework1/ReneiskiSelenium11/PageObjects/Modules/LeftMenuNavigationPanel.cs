using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Modules
{
    public class LeftMenuNavigationPanel
    {
        private MyWebElement ButtonMenuItem = new MyWebElement(By.XPath("//*[contains(text(), 'Buttons')]"));
        private MyWebElement CheckBoxMenuItem = new MyWebElement(By.XPath("//*[contains(text(), 'Check Box')]"));
        private MyWebElement LinksMenuItem = new MyWebElement(By.XPath("//*[contains(text(), 'Links')]"));
        private MyWebElement RadioButtonMenuItem = new MyWebElement(By.XPath("//*[contains(text(), 'Radio Button')]"));
        private MyWebElement WebTableMenuItem = new MyWebElement(By.XPath("//*[contains(text(), 'Web Tables')]"));

        public void GoToButtonsPage() => ButtonMenuItem.Click();

        public void GoToCheckBoxPage() => CheckBoxMenuItem.Click();

        public void GoToLinksPage() => LinksMenuItem.Click();

        public void GoToRadioButtonPage() => RadioButtonMenuItem.Click();

        public void GoToWebTablesPage() => WebTableMenuItem.Click();
    }
}
