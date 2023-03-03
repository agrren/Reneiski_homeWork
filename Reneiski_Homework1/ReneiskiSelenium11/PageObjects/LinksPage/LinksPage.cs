using OpenQA.Selenium;

namespace ReneiskiSelenium11.PageObjects.LinksPage
{
    public class LinksPage : BasePage
    {
        public LinksPage(IWebDriver _driver) : base(_driver)
        {
        }

        public string newUrl = "https://demoqa.com/";
        public string noContent = "Link has responded with staus 204 and status text No Content";

        private IWebElement currentUrl => _driver.FindElement(By.XPath("//a[@href='https://demoqa.com']"));

        public string GetUrlAttribute() => currentUrl.GetAttribute("href");

        public void SwitchPages(string value)
        {
            var windowHandles = _driver.WindowHandles.ToList();
            switch (value)
            {
                case "last":
                    _driver.SwitchTo().Window(windowHandles.Last());
                    break;
                case "first":
                    _driver.SwitchTo().Window(windowHandles.First());
                    break;
            }
        }
    }
}
