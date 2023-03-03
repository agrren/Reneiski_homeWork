using OpenQA.Selenium;

namespace ReneiskiSelenium11.PageObjects.ButtonPage
{
    public class ButtonPage : BasePage
    {
        public ButtonPage(IWebDriver _driver) : base(_driver)
        {
        }

        public IWebElement dynamicClick => _driver.FindElement(By.XPath("//*[(text()='Click Me')]"));
    }
}
