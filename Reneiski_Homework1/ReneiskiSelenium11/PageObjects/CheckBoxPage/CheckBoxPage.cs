using OpenQA.Selenium;

namespace ReneiskiSelenium11.PageObjects.CheckBoxPage
{
    public class CheckBoxPage : BasePage
    {
        public CheckBoxPage(IWebDriver _driver) : base(_driver)
        {
        }

        const string expectedText = "You have selected :\r\nhome\r\ndesktop\r\nnotes\r\ncommands\r\ndocuments\r\nworkspace\r\nreact\r\nangular\r\nveu\r\noffice\r\npublic\r\nprivate\r\nclassified\r\ngeneral\r\ndownloads\r\nwordFile\r\nexcelFile";

        private IWebElement result => _driver.FindElement(By.Id("result"));

        public void ClickCheckBox() => FindElementByXPathClass("rct-icon rct-icon-uncheck").Click();

        public bool GetAttributeCheckBox() => FindElementByXPathClass("rct-icon rct-icon-check").GetAttribute("class").Contains("check");

        public string TextResult() => result.Text;

        public string ExpectedText() => expectedText.ToString();
    }
}
