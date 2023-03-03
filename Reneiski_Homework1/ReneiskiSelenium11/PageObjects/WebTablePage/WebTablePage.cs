using OpenQA.Selenium;

namespace ReneiskiSelenium11.PageObjects.WebTablePage
{
    public class WebTablePage : BasePage
    {
        public string cCierra = "First Name";
        public string cVega = "Last Name";
        public string cAge = "Age";
        public string cEmail = "Email";
        public string cSalary = "Salary";
        public string cDepartament = "Department";

        public WebTablePage(IWebDriver _driver) : base(_driver)
        {
        }

        IWebElement FindElementByXPath(string columnName)
        {
            string xPath = string.Format("(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'{0}')]//ancestor::div[1]//preceding-sibling::div)]", columnName);
            var element = _driver.FindElement(By.XPath(xPath));
            return element;
        }

        public string ReturnText(string value)
        {
            var vega = FindElementByXPath(value);
            var text = vega.Text;
            return text;
        }

        private IWebElement textResult => _driver.FindElement(By.XPath("//*[@class='rt-tbody']/div[4]"));

        public string ReturnTextResult() => textResult.Text;
    }
}
