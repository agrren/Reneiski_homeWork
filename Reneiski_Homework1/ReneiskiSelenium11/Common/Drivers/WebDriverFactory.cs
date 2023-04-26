using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using ReneiskiSelenium11.Data;
using ReneiskiSelenium11.Data.Enums;
using System.Collections.Concurrent;

namespace ReneiskiSelenium11.Common.Drivers
{
    public class WebDriverFactory
    {
        private static readonly ConcurrentDictionary<string, IWebDriver> DriverCollection = new();

        public static IWebDriver Driver
        {
            get
            {
                if(!DriverCollection.Keys.Contains(TestContextValues.ExecutableClassName))
                {
                    InitializeDriver();
                }

                return DriverCollection.First(pair => pair.Key == TestContextValues.ExecutableClassName).Value;
            }

            set => DriverCollection.TryAdd(TestContextValues.ExecutableClassName, value);
        }

        public static Actions Actions => new Actions(Driver);

        public static IJavaScriptExecutor JavaScriptExecutor => (IJavaScriptExecutor)Driver;

        public static void QuitDriver() => Driver.Quit();

        public static void InitializeDriver()
        {
            Driver = TestSettings.Browser switch
            {
                Browsers.Chrome => new ChromeDriver(),
                Browsers.Edge => new EdgeDriver(),
                _ => throw new InvalidOperationException(),
            };

            Driver.Manage().Window.Maximize();
        }
    }
}
