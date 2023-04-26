using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class ButtonPage : BasePage
    {
        private MyWebElement buttonPage = new MyWebElement(By.XPath("//*[contains(text(), 'Buttons')]"));
        private MyWebElement dynamicClick = new MyWebElement(By.XPath("//*[(text()='Click Me')]"));
        private MyWebElement doublClickButton = new MyWebElement(By.XPath("//*[@id='doubleClickBtn']"));
        private MyWebElement rightClickButton = new MyWebElement(By.XPath("//*[@id='rightClickBtn']"));

        public void DynamicClick() => dynamicClick.Click();

        public void DoubleClick() => doublClickButton.ClickButton("doubleClickBtn");

        public void RightClick() => rightClickButton.ClickButton("rightClickBtn");

        public void GoToButtonsPage() => buttonPage.Click();
    }
}
