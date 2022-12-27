using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            _driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            var firstCheckBox = _driver.FindElement(By.XPath("//*[@class='rct-icon rct-icon-uncheck']"));
            firstCheckBox.Click();

            var checkedCheckbox = _driver.FindElement(By.XPath("//*[@class='rct-icon rct-icon-check']"));
            var isCheckboxChecked = checkedCheckbox.GetAttribute("class").Contains("check");
            
            Assert.IsTrue(isCheckboxChecked);

            var currentResult = _driver.FindElement(By.Id("result"));
            var currentResultText = currentResult.Text;
            
            Assert.AreEqual(currentResultText, ("You have selected :\r\nhome\r\ndesktop\r\nnotes\r\ncommands\r\ndocuments\r\nworkspace\r\nreact\r\nangular\r\nveu\r\noffice\r\npublic\r\nprivate\r\nclassified\r\ngeneral\r\ndownloads\r\nwordFile\r\nexcelFile"));
        }

        [Test]
        public void SecondRadioButtonTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/radio-button");

            var radioButtonYes = _driver.FindElement(By.XPath("//*[@for='yesRadio']"));
            radioButtonYes.Click();

            var currentResult = _driver.FindElement(By.XPath("//*[@class='mt-3']"));
            var currentResultText = currentResult.Text;

            Assert.AreEqual(currentResultText, "You have selected Yes");            

            var radioButtonImpressive = _driver.FindElement(By.XPath("//*[@for='impressiveRadio']"));
            radioButtonImpressive.Click();

            var currentResult1 = _driver.FindElement(By.XPath("//*[@class='mt-3']"));
            var currentResultText1 = currentResult1.Text;

            Assert.AreEqual(currentResultText1, "You have selected Impressive");            
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

            _driver.Navigate().GoToUrl("https://demoqa.com/webtables");

            var currentCierra = _driver.FindElement(By.XPath("(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'First Name')]//ancestor::div[1]//preceding-sibling::div)]"));
            var currentCierraText = currentCierra.Text;

            Assert.AreEqual(currentCierraText, ("Cierra"));

            var currentVega = _driver.FindElement(By.XPath("(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'Last Name')]//ancestor::div[1]//preceding-sibling::div)]"));
            var currentVegaText = currentVega.Text;

            Assert.AreEqual(currentVegaText, ("Vega"));

            var currentAge = _driver.FindElement(By.XPath("(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'Age')]//ancestor::div[1]//preceding-sibling::div)]"));
            var currentAgeText = currentAge.Text;

            Assert.AreEqual(currentAgeText, ("39"));

            var currentEmail = _driver.FindElement(By.XPath("(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'Email')]//ancestor::div[1]//preceding-sibling::div)]"));
            var currentEmailText = currentEmail.Text;

            Assert.AreEqual(currentEmailText, ("cierra@example.com"));

            var currentSalary = _driver.FindElement(By.XPath("(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'Salary')]//ancestor::div[1]//preceding-sibling::div)]"));
            var currentSalaryText = currentSalary.Text;

            Assert.AreEqual(currentSalaryText, ("10000"));

            var currentDepartment = _driver.FindElement(By.XPath("(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'Department')]//ancestor::div[1]//preceding-sibling::div)]"));
            var currentDepartmentText = currentDepartment.Text;

            Assert.AreEqual(currentDepartmentText, ("Insurance"));

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

            Assert.AreEqual(currentResultText1, ($"{firstName}\r\n{lastName}\r\n{userAge}\r\n{userEmail}\r\n{userSalary}\r\n{userDepartment}"));

            var editButton = _driver.FindElement(By.XPath("//*[@id='edit-record-4']"));
            editButton.Click();
            
            _driver.FindElement(By.XPath("//*[@id='salary']")).Clear();
            _driver.FindElement(By.XPath("//*[@id='salary']")).SendKeys(editedUserSalary);

            var submitButtonAfterEdit = _driver.FindElement(By.XPath("//*[@id='submit']"));
            submitButtonAfterEdit.Click();            

            var currentResult2 = _driver.FindElement(By.XPath("//*[@class='rt-tbody']/div[4]"));
            var currentResultText2 = currentResult2.Text;

            Assert.AreEqual(currentResultText2, ($"{firstName}\r\n{lastName}\r\n{userAge}\r\n{userEmail}\r\n{editedUserSalary}\r\n{userDepartment}"));

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

            Assert.AreEqual(doubleClickResultText, ("You have done a double click"));

            var rightClickButton = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='rightClickBtn']")));
            _driverActions.ContextClick(rightClickButton).Perform();

            var rightClickResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='rightClickMessage']")));
            var rightClickResultText = rightClickResult.Text;

            Assert.AreEqual(rightClickResultText, ("You have done a right click"));

            var dynamicClickButton = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[(text()='Click Me')]")));
            dynamicClickButton.Click();

            var dynamicClickResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='dynamicClickMessage']")));
            var dynamicClickResultText = dynamicClickResult.Text;

            Assert.AreEqual(dynamicClickResultText, ("You have done a dynamic click"));
        }

        [Test]
        public void FifthLinksTest()
        {
            const string newUrl = "https://demoqa.com/";

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

            Assert.AreEqual(createdButtonResultText, ("Link has responded with staus 201 and status text Created"));

            var noContentButton = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='no-content']")));
            noContentButton.Click();

            var noContentButtonResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//p[@id='linkResponse']")));
            var noContentButtonResultText = _driverWait.Until(drv => noContentButtonResult.Text);

            while (noContentButtonResultText != "Link has responded with staus 204 and status text No Content")

                try
                {
                    noContentButtonResultText = _driverWait.Until(drv => noContentButtonResult.Text);
                }
                catch (Exception)
                {
                    continue;
                }

            Assert.AreEqual(noContentButtonResultText, ("Link has responded with staus 204 and status text No Content"));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}