using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;
using ReneiskiSelenium11.Data.Constants;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class WebTablePage : BasePage
    {
        private MyWebElement webTablePage = new MyWebElement(By.XPath("//*[contains(text(), 'Web Tables')]"));
        private MyWebElement textResult = new MyWebElement(By.XPath("//*[@class='rt-tbody']/div[4]"));
        private MyWebElement addButton = new MyWebElement(By.XPath("//*[@id='addNewRecordButton']"));
        private MyWebElement submitButton = new MyWebElement(By.XPath("//*[@id='submit']"));
        private MyWebElement editButton = new MyWebElement(By.XPath("//*[@id='edit-record-4']"));
        private MyWebElement deleteButton = new MyWebElement(By.XPath("//*[@id='delete-record-4']"));

        public string GetCellText(string value)
        {
            string xPath = string.Format(Constants.xPath, value);
            var element = new MyWebElement(By.XPath(xPath));
            var text = element.Text;

            return text;
        }

        public string ReturnTextResult() => textResult.Text.Trim().Replace("\r\n", string.Empty);

        public void ClickAddButton() => addButton.Click();

        public void ClickSubmitButton() => submitButton.Click();

        public void ClickEditButton() => editButton.Click();

        public void ClickDeleteButton() => deleteButton.Click();

        public void GoToWebTablesPage() => webTablePage.Click();
    }
}
