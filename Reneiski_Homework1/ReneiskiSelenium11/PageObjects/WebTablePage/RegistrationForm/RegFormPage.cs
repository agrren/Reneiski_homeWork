using OpenQA.Selenium;

namespace ReneiskiSelenium11.PageObjects.WebTablePage.RegistrationForm
{
    public class RegFormPage : WebTablePage
    {
        public string firstName = "Alex";
        public string lastName = "Ren";
        public string userEmail = "Ren@tut.by";
        public string age = "41";
        public string salary = "20000";
        public string department = "QA";
        public string editedUserSalary = "22000";

        public RegFormPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void FillInValues(string value)
        {
            var elem = FindElementByXPathId(value);
            switch (value)
            {
                case "firstName":
                    elem.SendKeys(firstName);
                    break;
                case "lastName":
                    elem.SendKeys(lastName);
                    break;
                case "userEmail":
                    elem.SendKeys(userEmail);
                    break;
                case "age":
                    elem.SendKeys(age);
                    break;
                case "salary":
                    elem.SendKeys(salary);
                    break;
                case "department":
                    elem.SendKeys(department);
                    break;
            }
        }

        public void ClearSalary() => FindElementByXPathId("salary").Clear();

        public void FillInEditedValue(string value) => FindElementByXPathId(value).SendKeys(editedUserSalary);
    }
}
