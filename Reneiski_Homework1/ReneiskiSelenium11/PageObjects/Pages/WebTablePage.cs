using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class WebTablePage : BasePage
    {
        private MyWebElement TextResultElement = new MyWebElement(By.XPath("//*[@class='rt-tbody']/div[4]"));
        private MyWebElement AddButton = new MyWebElement(By.XPath("//*[@id='addNewRecordButton']"));
        private MyWebElement SubmitButton = new MyWebElement(By.XPath("//*[@id='submit']"));
        private MyWebElement EditButton = new MyWebElement(By.XPath("//*[@id='edit-record-4']"));
        private MyWebElement DeleteButton = new MyWebElement(By.XPath("//*[@id='delete-record-4']"));

        public string XPathToTableCell = "(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'{0}')]//ancestor::div[1]//preceding-sibling::div)]";

        public string GetCellText(string value)
        {
            var cellXPath = string.Format(XPathToTableCell, value);
            var element = new MyWebElement(By.XPath(cellXPath));
            var text = element.Text;

            return text;
        }

        public string ReturnTextResult() => TextResultElement.Text.Trim().Replace("\r\n", string.Empty);

        public void ClickAddButton() => AddButton.Click();

        public void ClickSubmitButton() => SubmitButton.Click();

        public void ClickEditButton() => EditButton.Click();

        public void ClickDeleteButton() => DeleteButton.Click();
    }
}
