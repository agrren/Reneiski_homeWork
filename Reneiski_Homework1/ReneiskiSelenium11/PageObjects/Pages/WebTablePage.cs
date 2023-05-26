using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;
using ReneiskiSelenium11.Data;
using ReneiskiSelenium11.Data.Constants;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class WebTablePage : BasePage
    {
        private MyWebElement WebTablePagePath = new MyWebElement(By.XPath("//*[contains(text(), 'Web Tables')]"));
        private MyWebElement TextRslt = new MyWebElement(By.XPath("//*[@class='rt-tbody']/div[4]"));
        private MyWebElement AddButton = new MyWebElement(By.XPath("//*[@id='addNewRecordButton']"));
        private MyWebElement SubmitButton = new MyWebElement(By.XPath("//*[@id='submit']"));
        private MyWebElement EditButton = new MyWebElement(By.XPath("//*[@id='edit-record-4']"));
        private MyWebElement DeleteButton = new MyWebElement(By.XPath("//*[@id='delete-record-4']"));

        public string GetCellText(string value)
        {
            var xPath = string.Format(ConstantsWebTablePage.XPathToTableCell, value);
            var element = new MyWebElement(By.XPath(xPath));
            var text = element.Text;

            return text;
        }

        public string ReturnTextResult() => TextRslt.Text.Trim().Replace("\r\n", string.Empty);

        public void ClickAddButton() => AddButton.Click();

        public void ClickSubmitButton() => SubmitButton.Click();

        public void ClickEditButton() => EditButton.Click();

        public void ClickDeleteButton() => DeleteButton.Click();

        public void GoToWebTablesPage() => WebTablePagePath.Click();
    }
}
