﻿using OpenQA.Selenium;
using ReneiskiSelenium11.Common.Drivers;
using ReneiskiSelenium11.Common.Extensions;
using System.Collections.ObjectModel;
using System.Drawing;

namespace ReneiskiSelenium11.Common.WebElements
{
    public class MyWebElement : IWebElement
    {
        protected By By { get; set; }

        protected IWebElement WebElement => WebDriverFactory.Driver.GetWebElementWhenExist(By);

        public string TagName => WebElement.TagName;

        public string Text => WebElement.Text;

        public bool Enabled => WebElement.Enabled;

        public bool Selected => WebElement.Selected;

        public Point Location => WebElement.Location;

        public Size Size => WebElement.Size;

        public bool Displayed => WebElement.Displayed;

        public MyWebElement(By by)
        {
            By = by;
        }

        public void Clear() => WebElement.Clear();

        public void SendKeys(string text) => WebElement.SendKeys(text);

        public void Submit() => WebElement.Submit();

        public void Click()
        {
            try
            {
                WebElement.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ScrollIntoView();
                WebElement.Click();
            }
        }

        public string GetAttribute(string attributeName) => WebElement.GetAttribute(attributeName);

        public string GetDomAttribute(string attributeName) => WebElement.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName) => WebElement.GetDomProperty(propertyName);

        public string GetCssValue(string propertyName) => WebElement.GetCssValue(propertyName);

        public ISearchContext GetShadowRoot() => WebElement.GetShadowRoot();

        public IWebElement FindElement(By by) => WebElement.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by) => WebElement.FindElements(by);

        public void ScrollIntoView() => WebDriverFactory.JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", WebElement);

        public string GetValueOfClassAtrubute() => GetAttribute("class");

        public static IWebElement FindElementById(string value) => WebDriverFactory.Driver.GetWebDriverWait().
            Until(drv => drv.FindElement(By.Id(string.Format("{0}", value))));
    }
}
