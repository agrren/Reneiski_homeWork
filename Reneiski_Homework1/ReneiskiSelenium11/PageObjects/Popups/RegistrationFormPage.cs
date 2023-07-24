using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;

namespace ReneiskiSelenium11.PageObjects.Popups
{
    public class RegistrationFormPage
    {
        private MyWebElement FirstNameTextBox = new MyWebElement(By.XPath("//*[@id='firstName']"));
        private MyWebElement LastNameTextBox = new MyWebElement(By.XPath("//*[@id='lastName']"));
        private MyWebElement UserEmailTextBox = new MyWebElement(By.XPath("//*[@id='userEmail']"));
        private MyWebElement AgeTextBox = new MyWebElement(By.XPath("//*[@id='age']"));
        private MyWebElement SalaryTextBox = new MyWebElement(By.XPath("//*[@id='salary']"));
        private MyWebElement DepartmentTextBox = new MyWebElement(By.XPath("//*[@id='department']"));

        public void EnterFirstName(string value) => FirstNameTextBox.SendKeys(value);

        public void EnterLastName(string value) => LastNameTextBox.SendKeys(value);

        public void EnterUserEmail(string value) => UserEmailTextBox.SendKeys(value);

        public void EnterAge(string value) => AgeTextBox.SendKeys(value);

        public void EnterSalary(string value) => SalaryTextBox.SendKeys(value);

        public void EnterDepartment(string value) => DepartmentTextBox.SendKeys(value);

        public void ClearSalary() => SalaryTextBox.Clear();

        public void EnterEditedSalary(string value) => SalaryTextBox.SendKeys(value);
    }
}
