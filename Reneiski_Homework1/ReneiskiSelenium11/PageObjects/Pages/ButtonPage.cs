using OpenQA.Selenium;
using ReneiskiSelenium11.Common.Drivers;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class ButtonPage : MainPage
    {
        private MyWebElement DynamicClickButton => new MyWebElement(By.XPath("//*[(text()='Click Me')]"));
        private MyWebElement DoubleClickTextElement => new MyWebElement(By.XPath("//*[@id='doubleClickMessage']"));
        private MyWebElement RightClickTextElement => new MyWebElement(By.XPath("//*[@id='rightClickMessage']"));
        private MyWebElement DynamicClickTextElement => new MyWebElement(By.XPath("//*[@id='dynamicClickMessage']"));

        public string ReturnDoubleClickTextResult() => DoubleClickTextElement.Text;

        public string ReturnRightClickTextResult() => RightClickTextElement.Text;

        public string ReturnDynamicClickTextResult() => DynamicClickTextElement.Text;

        public void DynamicClickDynamicClickButton() => DynamicClickButton.Click();

        public void DoubleClickDoubleClickButton() => WebDriverFactory.Actions.DoubleClick(MyWebElement.FindElementById("doubleClickBtn")).Perform();

        public void RightClickRightClickButton() => WebDriverFactory.Actions.ContextClick(MyWebElement.FindElementById("rightClickBtn")).Perform();
    }
}
