using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class RadioButtonPage : BasePage
    {
        private MyWebElement classMt = new MyWebElement(By.XPath("//*[@class='mt-3']"));
        private MyWebElement radioButtonPage = new MyWebElement(By.XPath("//*[contains(text(), 'Radio Button')]"));
        private MyWebElement yesRadiobtn = new MyWebElement(By.XPath("//*[@for='yesRadio']"));
        private MyWebElement impressiveRadioBtn = new MyWebElement(By.XPath("//*[@for='impressiveRadio']"));

        public void YesRadioBtnClick() => yesRadiobtn.Click();

        public void ImpRadioBtnClick() => impressiveRadioBtn.Click();

        public string GetTextYesResult() => classMt.Text;

        public void GoToRadioButtonPage() => radioButtonPage.Click();
    }
}
