using OpenQA.Selenium;
using ReneiskiSelenium11.Common.Drivers;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class ButtonPage : BasePage
    {
        private MyWebElement ButtonPagePath = new MyWebElement(By.XPath("//*[contains(text(), 'Buttons')]"));
        private MyWebElement DynamicClickButton = new MyWebElement(By.XPath("//*[(text()='Click Me')]"));
        private MyWebElement DoubleClickText = new MyWebElement(By.XPath("//*[@id='doubleClickMessage']"));
        private MyWebElement RightClickText = new MyWebElement(By.XPath("//*[@id='rightClickMessage']"));
        private MyWebElement DynamicClickText = new MyWebElement(By.XPath("//*[@id='dynamicClickMessage']"));

        public string ReturnDoubleClickTextResult() => DoubleClickText.Text;

        public string ReturnRightClickTextResult() => RightClickText.Text;

        public string ReturnDynamicClickTextResult() => DynamicClickText.Text;

        public void DynamicClick() => DynamicClickButton.Click();

        public void GoToButtonsPage() => ButtonPagePath.Click();

        public void DoubleClick() => WebDriverFactory.Actions.DoubleClick(MyWebElement.FindElementByXPathId("doubleClickBtn")).Perform();

        public void RightClick() => WebDriverFactory.Actions.ContextClick(MyWebElement.FindElementByXPathId("rightClickBtn")).Perform();
    }
}
