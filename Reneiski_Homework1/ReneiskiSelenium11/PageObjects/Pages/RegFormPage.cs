using OpenQA.Selenium;
using ReneiskiSelenium11.Common.WebElements;
using ReneiskiSelenium11.Data;

namespace ReneiskiSelenium11.PageObjects.Pages
{
    public class RegFormPage : WebTablePage
    {
        private MyWebElement firstName = new MyWebElement(By.XPath("//*[@id='firstName']"));
        private MyWebElement lastName = new MyWebElement(By.XPath("//*[@id='lastName']"));
        private MyWebElement userEmail = new MyWebElement(By.XPath("//*[@id='userEmail']"));
        private MyWebElement age = new MyWebElement(By.XPath("//*[@id='age']"));
        private MyWebElement salary = new MyWebElement(By.XPath("//*[@id='salary']"));
        private MyWebElement department = new MyWebElement(By.XPath("//*[@id='department']"));

        public void EnterFirstName() => firstName.SendKeys(TestSettings.firstName);

        public void EnterLastName() => lastName.SendKeys(TestSettings.lastName);

        public void EnterUserEmail() => userEmail.SendKeys(TestSettings.userEmail);

        public void EnterAge() => age.SendKeys(TestSettings.age);

        public void EnterSalary() => salary.SendKeys(TestSettings.salary);

        public void EnterDepartment() => department.SendKeys(TestSettings.department);

        public void ClearSalary() => salary.Clear();

        public void EnterEditedSalary() => salary.SendKeys(TestSettings.editedUserSalary);
    }
}
