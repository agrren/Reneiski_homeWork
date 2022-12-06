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
        private IWebElement _element;
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

            var checkboxIsChecked = _driver.FindElement(By.XPath("//*[@class='rct-icon rct-icon-check']"));
            string attributeClass = checkboxIsChecked.GetAttribute("class");
            Assert.IsTrue(attributeClass.Contains("rct-icon rct-icon-check"));

            var currentResult = _driver.FindElement(By.Id("result"));
            var currentResultText = currentResult.Text;

            Assert.IsTrue(currentResultText.Contains("You have selected :"));
            Assert.IsTrue(currentResultText.Contains("home"));
            Assert.IsTrue(currentResultText.Contains("desktop"));
            Assert.IsTrue(currentResultText.Contains("notes"));
            Assert.IsTrue(currentResultText.Contains("commands"));
            Assert.IsTrue(currentResultText.Contains("documents"));
            Assert.IsTrue(currentResultText.Contains("workspace"));
            Assert.IsTrue(currentResultText.Contains("react"));
            Assert.IsTrue(currentResultText.Contains("angular"));
            Assert.IsTrue(currentResultText.Contains("veu"));
            Assert.IsTrue(currentResultText.Contains("office"));
            Assert.IsTrue(currentResultText.Contains("public"));
            Assert.IsTrue(currentResultText.Contains("private"));
            Assert.IsTrue(currentResultText.Contains("classified"));
            Assert.IsTrue(currentResultText.Contains("general"));
            Assert.IsTrue(currentResultText.Contains("downloads"));
            Assert.IsTrue(currentResultText.Contains("wordFile"));
            Assert.IsTrue(currentResultText.Contains("excelFile"));
        }

        [Test]
        public void SecondRadioButtonTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/radio-button");

            var radioButtonYes = _driver.FindElement(By.XPath("//*[@for='yesRadio']"));
            radioButtonYes.Click();

            var currentResult = _driver.FindElement(By.XPath("//*[@class='mt-3']"));
            var currentResultText = currentResult.Text;

            Assert.IsTrue(currentResultText.Contains("You have selected "));
            Assert.IsTrue(currentResultText.Contains("Yes"));

            var radioButtonImpressive = _driver.FindElement(By.XPath("//*[@for='impressiveRadio']"));
            radioButtonImpressive.Click();

            var currentResult1 = _driver.FindElement(By.XPath("//*[@class='mt-3']"));
            var currentResultText1 = currentResult1.Text;

            Assert.IsTrue(currentResultText1.Contains("You have selected "));
            Assert.IsTrue(currentResultText1.Contains("Impressive"));
        }

        [Test]
        public void ThirdWebTablesTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/webtables");

            var currentResult = _driver.FindElement(By.XPath("//*[@class='rt-table']"));
            var currentResultText = currentResult.Text;

            Assert.IsTrue(currentResultText.Contains("Cierra"));
            Assert.IsTrue(currentResultText.Contains("Vega"));
            Assert.IsTrue(currentResultText.Contains("39"));
            Assert.IsTrue(currentResultText.Contains("cierra@example.com"));
            Assert.IsTrue(currentResultText.Contains("10000"));

            var addButton = _driver.FindElement(By.XPath("//*[@id='addNewRecordButton']"));
            addButton.Click();

            var firstName = "Alex";
            var firstNameTextBox = _driver.FindElement(By.XPath("//*[@id='firstName']"));
            firstNameTextBox.SendKeys(firstName);

            var lastName = "Ren";
            var lastNameTextBox = _driver.FindElement(By.XPath("//*[@id='lastName']"));
            lastNameTextBox.SendKeys(lastName);

            var userEmail = "Ren@tut.by";
            var userEmailTextBox = _driver.FindElement(By.XPath("//*[@id='userEmail']"));
            userEmailTextBox.SendKeys(userEmail);

            var userAge = "41";
            var userAgeTextBox = _driver.FindElement(By.XPath("//*[@id='age']"));
            userAgeTextBox.SendKeys(userAge);

            var userSalary = "20000";
            var userSalaryTextBox = _driver.FindElement(By.XPath("//*[@id='salary']"));
            userSalaryTextBox.SendKeys(userSalary);

            var userDepartment = "QA";
            var userDepartmentTextBox = _driver.FindElement(By.XPath("//*[@id='department']"));
            userDepartmentTextBox.SendKeys(userDepartment);

            var submitButton = _driver.FindElement(By.XPath("//*[@id='submit']"));
            submitButton.Click();

            var currentResult1 = _driver.FindElement(By.XPath("//*[@class='rt-table']"));
            var currentResultText1 = currentResult1.Text;

            Assert.IsTrue(currentResultText1.Contains(firstName));
            Assert.IsTrue(currentResultText1.Contains(lastName));
            Assert.IsTrue(currentResultText1.Contains(userAge));
            Assert.IsTrue(currentResultText1.Contains(userEmail));
            Assert.IsTrue(currentResultText1.Contains(userSalary));
            Assert.IsTrue(currentResultText1.Contains(userDepartment));

            var editButton = _driver.FindElement(By.XPath("//*[@id='edit-record-4']"));
            editButton.Click();

            var editedUserSalary = "22000";
            var editedUserSalaryTextBox = _driver.FindElement(By.XPath("//*[@id='salary']"));
            editedUserSalaryTextBox.Clear();
            editedUserSalaryTextBox.SendKeys(editedUserSalary);

            var submitButtonAfterEdit = _driver.FindElement(By.XPath("//*[@id='submit']"));
            submitButtonAfterEdit.Click();

            var deleteButton = _driver.FindElement(By.XPath("//*[@id='delete-record-4']"));
            deleteButton.Click();

            var currentResult2 = _driver.FindElement(By.XPath("//*[@class='rt-table']"));
            var currentResultText2 = currentResult2.Text;

            Assert.IsFalse(currentResultText2.Contains(firstName));
            Assert.IsFalse(currentResultText2.Contains(lastName));
            Assert.IsFalse(currentResultText2.Contains(userAge));
            Assert.IsFalse(currentResultText2.Contains(userEmail));
            Assert.IsFalse(currentResultText2.Contains(userSalary));
            Assert.IsFalse(currentResultText2.Contains(userDepartment));
        }

        [Test]
        public void ForthButtonsTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/buttons");

            var doubleClickButton = _driver.FindElement(By.XPath("//*[@id='doubleClickBtn']"));
            _driverActions.DoubleClick(doubleClickButton).Perform();

            var doubleClickResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='doubleClickMessage']")));
            var doubleClickResultText = doubleClickResult.Text;

            Assert.IsTrue(doubleClickResultText.Contains("You have done a double click"));

            var rightClickButton = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='rightClickBtn']")));
            _driverActions.ContextClick(rightClickButton).Perform();

            var rightClickResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='rightClickMessage']")));
            var rightClickResultText = rightClickResult.Text;

            Assert.IsTrue(rightClickResultText.Contains("You have done a right click"));

            var dynamicClickButton = _driverWait.Until(drv => drv.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/button")));
            dynamicClickButton.Click();

            var dynamicClickResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='dynamicClickMessage']")));
            var dynamicClickResultText = dynamicClickResult.Text;

            Assert.IsTrue(dynamicClickResultText.Contains("You have done a dynamic click"));
        }

        [Test]
        public void FifthLinksTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/links");

            var simpleLink = _driver.FindElement(By.XPath("//*[@id='simpleLink']"));
            simpleLink.Click();

            var currentUrl = _driver.FindElement(By.XPath("//p/a[@href='https://demoqa.com']"));
            var currentUrlResult = currentUrl.GetAttribute("href");

            List<string> windowHandles = _driver.WindowHandles.ToList();
            _driver.SwitchTo().Window(windowHandles.Last());

            var newUrl = _driver.Url;
            Assert.AreEqual(newUrl, currentUrlResult);

            _driver.SwitchTo().Window(windowHandles.First());

            var createdLink = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='created']")));
            createdLink.Click();

            var createdLinkResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='linkResponse']")));
            var createdLinkResultText = createdLinkResult.Text;

            Assert.IsTrue(createdLinkResultText.Contains("Link has responded with staus 201 and status text Created"));

            var noContentLink = _driverWait.Until(drv => drv.FindElement(By.XPath("//*[@id='no-content']")));
            noContentLink.Click();

            var noContentLinkResult = _driverWait.Until(drv => drv.FindElement(By.XPath("//p[@id='linkResponse']")));
            var noContentLinkResultText = _driverWait.Until(drv => noContentLinkResult.Text);

            while (noContentLinkResultText != "Link has responded with staus 204 and status text No Content")

                try
                {
                    noContentLinkResultText = _driverWait.Until(drv => noContentLinkResult.Text);
                }
                catch (Exception)
                {
                    continue;
                }

            Assert.IsTrue(noContentLinkResultText.Contains("Link has responded with staus 204 and status text No Content"));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}