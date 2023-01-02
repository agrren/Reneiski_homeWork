using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Network;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Reneiski_Homework1
{
    public class Selenium
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        private Actions _driverActions;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            _driverActions = new Actions(_driver);
        }

        [Test]
        public void FirstCheckBoxTest()
        {
            const string expectedText = "You have selected :\r\nhome\r\ndesktop\r\nnotes\r\ncommands\r\ndocuments\r\nworkspace\r\nreact\r\nangular\r\nveu\r\noffice\r\npublic\r\nprivate\r\nclassified\r\ngeneral\r\ndownloads\r\nwordFile\r\nexcelFile";
            _driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            var firstCheckBox = _driver.FindElement(By.XPath("//*[@class='rct-icon rct-icon-uncheck']"));
            firstCheckBox.Click();

            var checkedCheckbox = _driver.FindElement(By.XPath("//*[@class='rct-icon rct-icon-check']"));
            var isCheckboxChecked = checkedCheckbox.GetAttribute("class").Contains("check");
            Assert.IsTrue(isCheckboxChecked);

            var currentResult = _driver.FindElement(By.Id("result"));
            var currentResultText = currentResult.Text;
            Assert.AreEqual(expectedText, currentResultText);
        }

        [Test]
        public void SecondRadioButtonTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/radio-button");

            var radioButtonYes = _driver.FindElement(By.XPath("//*[@for='yesRadio']"));
            radioButtonYes.Click();

            var currentResult = _driver.FindElement(By.XPath("//*[@class='mt-3']"));
            var currentResultText = currentResult.Text;
            Assert.AreEqual("You have selected Yes", currentResultText);

            var radioButtonImpressive = _driver.FindElement(By.XPath("//*[@for='impressiveRadio']"));
            radioButtonImpressive.Click();

            var currentResult1 = _driver.FindElement(By.XPath("//*[@class='mt-3']"));
            var currentResultText1 = currentResult1.Text;
            Assert.AreEqual("You have selected Impressive", currentResultText1);
        }

        [Test]
        public void ThirdWebTablesTest()
        {
            var firstName = "Alex";
            var lastName = "Ren";
            var userEmail = "Ren@tut.by";
            var userAge = "41";
            var userSalary = "20000";
            var userDepartment = "QA";
            var editedUserSalary = "22000";

            IWebElement FindElementByXPath(string columnName)
            {
                string xPath = string.Format("(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'{0}')]//ancestor::div[1]//preceding-sibling::div)]", columnName);
                var element = _driver.FindElement(By.XPath(xPath));
                return element;
            }

            _driver.Navigate().GoToUrl("https://demoqa.com/webtables");

            var currentCierra = FindElementByXPath("First Name");
            var currentCierraText = currentCierra.Text;
            Assert.AreEqual("Cierra", currentCierraText);

            var currentVega = FindElementByXPath("Last Name");
            var currentVegaText = currentVega.Text;
            Assert.AreEqual("Vega", currentVegaText);

            var currentAge = FindElementByXPath("Age");
            var currentAgeText = currentAge.Text;
            Assert.AreEqual("39", currentAgeText);

            var currentEmail = FindElementByXPath("Email");
            var currentEmailText = currentEmail.Text;
            Assert.AreEqual("cierra@example.com", currentEmailText);

            var currentSalary = FindElementByXPath("Salary");
            var currentSalaryText = currentSalary.Text;
            Assert.AreEqual("10000", currentSalaryText);

            var currentDepartment = FindElementByXPath("Department");
            var currentDepartmentText = currentDepartment.Text;
            Assert.AreEqual("Insurance", currentDepartmentText);

            var addButton = _driver.FindElement(By.XPath("//*[@id='addNewRecordButton']"));
            addButton.Click();

            var firstNameTextBox = _driver.FindElement(By.XPath("//*[@id='firstName']"));
            firstNameTextBox.SendKeys(firstName);

            var lastNameTextBox = _driver.FindElement(By.XPath("//*[@id='lastName']"));
            lastNameTextBox.SendKeys(lastName);

            var userEmailTextBox = _driver.FindElement(By.XPath("//*[@id='userEmail']"));
            userEmailTextBox.SendKeys(userEmail);

            var userAgeTextBox = _driver.FindElement(By.XPath("//*[@id='age']"));
            userAgeTextBox.SendKeys(userAge);

            var userSalaryTextBox = _driver.FindElement(By.XPath("//*[@id='salary']"));
            userSalaryTextBox.SendKeys(userSalary);

            var userDepartmentTextBox = _driver.FindElement(By.XPath("//*[@id='department']"));
            userDepartmentTextBox.SendKeys(userDepartment);

            var submitButton = _driver.FindElement(By.XPath("//*[@id='submit']"));
            submitButton.Click();

            var currentResult1 = _driver.FindElement(By.XPath("//*[@class='rt-tbody']/div[4]"));
            var currentResultText1 = currentResult1.Text;
            Assert.AreEqual($"{firstName}\r\n{lastName}\r\n{userAge}\r\n{userEmail}\r\n{userSalary}\r\n{userDepartment}", currentResultText1);

            var editButton = _driver.FindElement(By.XPath("//*[@id='edit-record-4']"));
            editButton.Click();

            var editUserSalary = _driver.FindElement(By.XPath("//*[@id='salary']"));
            editUserSalary.Clear();
            editUserSalary.SendKeys(editedUserSalary);

            var submitButtonAfterEdit = _driver.FindElement(By.XPath("//*[@id='submit']"));
            submitButtonAfterEdit.Click();

            var currentResult2 = _driver.FindElement(By.XPath("//*[@class='rt-tbody']/div[4]"));
            var currentResultText2 = currentResult2.Text;
            Assert.AreEqual($"{firstName}\r\n{lastName}\r\n{userAge}\r\n{userEmail}\r\n{editedUserSalary}\r\n{userDepartment}", currentResultText2);

            var deleteButton = _driver.FindElement(By.XPath("//*[@id='delete-record-4']"));
            deleteButton.Click();
        }

        [Test]
        public void ForthButtonsTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/buttons");

            var doubleClickButton = _driver.FindElement(By.XPath("//*[@id='doubleClickBtn']"));
            _driverActions.DoubleClick(doubleClickButton).Perform();

            var doubleClickResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='doubleClickMessage']")));
            var doubleClickResultText = doubleClickResult.Text;
            Assert.AreEqual("You have done a double click", doubleClickResultText);

            var rightClickButton = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='rightClickBtn']")));
            _driverActions.ContextClick(rightClickButton).Perform();

            var rightClickResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='rightClickMessage']")));
            var rightClickResultText = rightClickResult.Text;
            Assert.AreEqual("You have done a right click", rightClickResultText);

            var dynamicClickButton = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[(text()='Click Me')]")));
            dynamicClickButton.Click();

            var dynamicClickResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='dynamicClickMessage']")));
            var dynamicClickResultText = dynamicClickResult.Text;
            Assert.AreEqual("You have done a dynamic click", dynamicClickResultText);
        }

        [Test]
        public void FifthLinksTest()
        {
            const string newUrl = "https://demoqa.com/";
            const string noContent = "Link has responded with staus 204 and status text No Content";

            _driver.Navigate().GoToUrl("https://demoqa.com/links");

            var homeButton = _driver.FindElement(By.XPath("//*[@id='simpleLink']"));
            homeButton.Click();

            var currentUrl = _driver.FindElement(By.XPath("//p/a[@href='https://demoqa.com']"));
            var currentUrlResult = currentUrl.GetAttribute("href");

            var windowHandles = _driver.WindowHandles.ToList();
            _driver.SwitchTo().Window(windowHandles.Last());
            Assert.AreEqual(newUrl, currentUrlResult);

            _driver.SwitchTo().Window(windowHandles.First());

            var createdButton = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='created']")));
            createdButton.Click();

            var createdButtonResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='linkResponse']")));
            var createdButtonResultText = createdButtonResult.Text;
            Assert.AreEqual("Link has responded with staus 201 and status text Created", createdButtonResultText);

            var noContentButton = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='no-content']")));
            noContentButton.Click();

            var noContentButtonResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='linkResponse']")));
            var noContentButtonResultText = _driverWait.Until(drv => noContentButtonResult.Text == noContent);

            Assert.IsTrue(noContentButtonResultText);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}