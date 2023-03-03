using NUnit.Framework;
using ReneiskiSelenium11.PageObjects.ButtonPage;
using ReneiskiSelenium11.PageObjects.CheckBoxPage;
using ReneiskiSelenium11.PageObjects.LinksPage;
using ReneiskiSelenium11.PageObjects.RadioButtonPage;
using ReneiskiSelenium11.PageObjects.WebTablePage;
using ReneiskiSelenium11.PageObjects.WebTablePage.RegistrationForm;

namespace ReneiskiSelenium11.Tests
{
    public class Selenium : BaseTest
    {

        [Test]
        public void FirstCheckBoxTest()
        {
            CheckBoxPage check = new CheckBoxPage(_driver);

            check.GoToPage("checkbox");

            check.ClickCheckBox();

            Assert.IsTrue(check.GetAttributeCheckBox());

            Assert.AreEqual(check.ExpectedText(), check.TextResult());
        }

        [Test]
        public void SecondRadioButtonTest()
        {
            RadioButtonPage buttonPage = new RadioButtonPage(_driver);

            buttonPage.GoToPage("radio-button");

            buttonPage.yesRadiobtn.Click();

            Assert.AreEqual("You have selected Yes", buttonPage.TextYesResult());

            buttonPage.impressiveRadioBtn.Click();

            Assert.AreEqual("You have selected Impressive", buttonPage.TextYesResult());
        }

        [Test]
        public void ThirdWebTablesTest()
        {
            WebTablePage webTablePage = new WebTablePage(_driver);
            RegFormPage regForm = new RegFormPage(_driver);

            webTablePage.GoToPage("webtables");

            Assert.AreEqual("Cierra", webTablePage.ReturnText(webTablePage.cCierra));
            Assert.AreEqual("Vega", webTablePage.ReturnText(webTablePage.cVega));
            Assert.AreEqual("39", webTablePage.ReturnText(webTablePage.cAge));
            Assert.AreEqual("cierra@example.com", webTablePage.ReturnText(webTablePage.cEmail));
            Assert.AreEqual("10000", webTablePage.ReturnText(webTablePage.cSalary));
            Assert.AreEqual("Insurance", webTablePage.ReturnText(webTablePage.cDepartament));

            webTablePage.ClickBtn("addNewRecordButton");

            regForm.FillInValues("firstName");
            regForm.FillInValues("lastName");
            regForm.FillInValues("userEmail");
            regForm.FillInValues("age");
            regForm.FillInValues("salary");
            regForm.FillInValues("department");

            webTablePage.ClickBtn("submit");

            Assert.AreEqual($"{regForm.firstName}\r\n{regForm.lastName}\r\n{regForm.age}\r\n{regForm.userEmail}\r\n{regForm.salary}\r\n{regForm.department}", webTablePage.ReturnTextResult());

            webTablePage.ClickBtn("edit-record-4");
            regForm.ClearSalary();
            regForm.FillInEditedValue("salary");
            webTablePage.ClickBtn("submit");

            Assert.AreEqual($"{regForm.firstName}\r\n{regForm.lastName}\r\n{regForm.age}\r\n{regForm.userEmail}\r\n{regForm.editedUserSalary}\r\n{regForm.department}", webTablePage.ReturnTextResult());

            webTablePage.ClickBtn("delete-record-4");
        }

        [Test]
        public void ForthButtonsTest()
        {
            ButtonPage buttonPage = new ButtonPage(_driver);

            buttonPage.GoToPage("buttons");

            buttonPage.ClickButton("doubleClickBtn");
            Assert.AreEqual("You have done a double click", buttonPage.TextResult("doubleClickMessage"));

            buttonPage.ClickButton("rightClickBtn");
            Assert.AreEqual("You have done a right click", buttonPage.TextResult("rightClickMessage"));

            buttonPage.dynamicClick.Click();
            Assert.AreEqual("You have done a dynamic click", buttonPage.TextResult("dynamicClickMessage"));
        }

        [Test]
        public void FifthLinksTest()
        {
            LinksPage linksPage = new LinksPage(_driver);

            linksPage.GoToPage("links");

            linksPage.ClickBtn("simpleLink");
            linksPage.SwitchPages("last");
            Assert.AreEqual(linksPage.newUrl, linksPage.GetUrlAttribute());

            linksPage.SwitchPages("first");

            linksPage.ClickBtn("created");
            Assert.AreEqual("Link has responded with staus 201 and status text Created", linksPage.TextResult("linkResponse"));

            linksPage.ClickBtn("no-content");
            var noContentButtonResultText = _driverWait.Until(drv => linksPage.TextResult("linkResponse") == linksPage.noContent);

            Assert.IsTrue(noContentButtonResultText);
        }
    }
}