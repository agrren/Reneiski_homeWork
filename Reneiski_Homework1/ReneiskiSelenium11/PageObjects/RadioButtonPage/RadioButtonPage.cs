using OpenQA.Selenium;

namespace ReneiskiSelenium11.PageObjects.RadioButtonPage
{
    public class RadioButtonPage : BasePage
    {
        public RadioButtonPage(IWebDriver _driver) : base(_driver)
        {
        }

        public IWebElement yesRadiobtn => _driver.FindElement(By.XPath("//*[@for='yesRadio']"));

        public IWebElement impressiveRadioBtn => _driver.FindElement(By.XPath("//*[@for='impressiveRadio']"));

        public string TextYesResult() => FindElementByXPathClass("mt-3").Text;
    }
}
