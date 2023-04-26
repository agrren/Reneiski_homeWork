using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class LinksPage : BasePage
    {
        private MyWebElement linksPage = new MyWebElement(By.XPath("//*[contains(text(), 'Links')]"));
        private MyWebElement currentUrl = new MyWebElement(By.XPath("//a[@href='https://demoqa.com']"));
        private MyWebElement simpleLink = new MyWebElement(By.XPath("//*[@id='simpleLink']"));
        private MyWebElement created = new MyWebElement(By.XPath("//*[@id='created']"));
        private MyWebElement noContent = new MyWebElement(By.XPath("//*[@id='no-content']"));

        public string GetUrlAttribute() => currentUrl.GetAttribute("href");

        public void ClickSimpleLink() => simpleLink.Click();

        public void ClickCreated() => created.Click();

        public void ClickNoContent() => noContent.Click();

        public void GoToLinksPage() => linksPage.Click();
    }
}
