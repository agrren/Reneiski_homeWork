using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class CheckBoxPage : BasePage
    {
        private MyWebElement TextOfResultElement => new MyWebElement(By.Id("result"));
        private MyWebElement CheckBoxHome => new MyWebElement(By.XPath("//*[@class='rct-icon rct-icon-uncheck']"));
        private MyWebElement CheckBoxAttribute => new MyWebElement(By.XPath("//*[@class='rct-icon rct-icon-check']"));

        public void ClickHomeCheckBox() => CheckBoxHome.Click();

        public bool IsHomeCheckBoxChecked() => CheckBoxAttribute.GetAttribute("class").Contains("check");

        public string GetTextResultAfterHomeChecked() => TextOfResultElement.Text;
    }
}
