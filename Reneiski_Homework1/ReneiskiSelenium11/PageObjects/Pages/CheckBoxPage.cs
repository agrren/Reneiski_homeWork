using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class CheckBoxPage : BasePage
    {
        private MyWebElement TextOfResult = new MyWebElement(By.Id("result"));
        private MyWebElement CheckBoxHome = new MyWebElement(By.XPath("//*[@class='rct-icon rct-icon-uncheck']"));
        private MyWebElement CheckBoxAttribute = new MyWebElement(By.XPath("//*[@class='rct-icon rct-icon-check']"));
        private MyWebElement CheckBoxPagePath = new MyWebElement(By.XPath("//*[contains(text(), 'Check Box')]"));

        public void ClickHomeCheckBox() => CheckBoxHome.Click();

        public bool IsHomeCheckBoxChecked() => CheckBoxAttribute.GetAttribute("class").Contains("check");

        public string GetTextResult() => TextOfResult.Text;

        public void GoToCheckBoxPage() => CheckBoxPagePath.Click();
    }
}
