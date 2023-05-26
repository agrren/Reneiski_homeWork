using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;
using ReneiskiSelenium11.Data;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class RegFormPage : WebTablePage
    {
        private MyWebElement FirstNameCell = new MyWebElement(By.XPath("//*[@id='firstName']"));
        private MyWebElement LastNameCell = new MyWebElement(By.XPath("//*[@id='lastName']"));
        private MyWebElement UserEmailCell = new MyWebElement(By.XPath("//*[@id='userEmail']"));
        private MyWebElement AgeCell = new MyWebElement(By.XPath("//*[@id='age']"));
        private MyWebElement SalaryCell = new MyWebElement(By.XPath("//*[@id='salary']"));
        private MyWebElement DepartmentCell = new MyWebElement(By.XPath("//*[@id='department']"));

        public void EnterFirstName(string value) => FirstNameCell.SendKeys(value);

        public void EnterLastName(string value) => LastNameCell.SendKeys(value);

        public void EnterUserEmail(string value) => UserEmailCell.SendKeys(value);

        public void EnterAge(string value) => AgeCell.SendKeys(value);

        public void EnterSalary(string value) => SalaryCell.SendKeys(value);

        public void EnterDepartment(string value) => DepartmentCell.SendKeys(value);

        public void ClearSalary() => SalaryCell.Clear();

        public void EnterEditedSalary(string value) => SalaryCell.SendKeys(value);
    }
}
