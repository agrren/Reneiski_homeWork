using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class LinksPage : BasePage
    {
        private MyWebElement LinksPagePath = new MyWebElement(By.XPath("//*[contains(text(), 'Links')]"));
        private MyWebElement CurrentUrlAttribute = new MyWebElement(By.XPath("//a[@href='https://demoqa.com']"));
        private MyWebElement HomeLink = new MyWebElement(By.XPath("//*[@id='simpleLink']"));
        private MyWebElement CreatedLink = new MyWebElement(By.XPath("//*[@id='created']"));
        private MyWebElement NoContentLink = new MyWebElement(By.XPath("//*[@id='no-content']"));
        private MyWebElement CreatedLinkTextResult = new MyWebElement(By.XPath("//*[@id='linkResponse']"));

        public string GetUrlAttribute() => CurrentUrlAttribute.GetAttribute("href");

        public string ReturnCreatedLinkTextResult() => CreatedLinkTextResult.Text;

        public void ClickHomeLink() => HomeLink.Click();

        public void ClickCreatedLink() => CreatedLink.Click();

        public void ClickNoContentLink() => NoContentLink.Click();

        public void GoToLinksPage() => LinksPagePath.Click();
    }
}
