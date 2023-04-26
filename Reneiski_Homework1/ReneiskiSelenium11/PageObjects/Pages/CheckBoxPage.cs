using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class CheckBoxPage : BasePage
    {
        private MyWebElement result = new MyWebElement(By.Id("result"));
        private MyWebElement classUnCheck = new MyWebElement(By.XPath("//*[@class='rct-icon rct-icon-uncheck']"));
        private MyWebElement classCheck = new MyWebElement(By.XPath("//*[@class='rct-icon rct-icon-check']"));
        private MyWebElement checkBoxPage = new MyWebElement(By.XPath("//*[contains(text(), 'Check Box')]"));

        public void ClickCheckBox() => classUnCheck.Click();

        public bool GetAttributeCheckBox() => classCheck.GetAttribute("class").Contains("check");

        public string GetTextResult() => result.Text;

        public void GoToCheckBoxPage() => checkBoxPage.Click();
    }
}
