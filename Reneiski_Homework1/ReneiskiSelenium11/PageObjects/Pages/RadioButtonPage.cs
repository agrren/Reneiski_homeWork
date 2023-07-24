using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class RadioButtonPage : BasePage
    {
        private MyWebElement TextResultAfterClickElement = new MyWebElement(By.XPath("//*[@class='mt-3']"));
        private MyWebElement YesRadioButton = new MyWebElement(By.XPath("//*[@for='yesRadio']"));
        private MyWebElement ImpressiveRadioButton = new MyWebElement(By.XPath("//*[@for='impressiveRadio']"));

        public void ClickYesRadioButton() => YesRadioButton.Click();

        public void ClickImpressiveRadioButton() => ImpressiveRadioButton.Click();

        public string GetTextResultAfterClick() => TextResultAfterClickElement.Text;
    }
}
