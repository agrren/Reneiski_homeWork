using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class LinksPage : BasePage
    {
        private MyWebElement HomeLink = new MyWebElement(By.XPath("//*[@id='simpleLink']"));
        private MyWebElement CreatedLink = new MyWebElement(By.XPath("//*[@id='created']"));
        private MyWebElement NoContentLink = new MyWebElement(By.XPath("//*[@id='no-content']"));
        private MyWebElement CreatedLinkTextElement = new MyWebElement(By.XPath("//*[@id='linkResponse']"));

        public string GetCurrentPageUrl() => Driver.Url;

        public string ReturnCreatedLinkTextResult() => CreatedLinkTextElement.Text;

        public void ClickHomeLink() => HomeLink.Click();

        public void ClickCreatedLink() => CreatedLink.Click();

        public void ClickNoContentLink() => NoContentLink.Click();
    }
}
