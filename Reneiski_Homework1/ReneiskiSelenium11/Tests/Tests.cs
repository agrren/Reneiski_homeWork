using NUnit.Framework;
using ReneiskiSelenium11.Common.Extensions;
using ReneiskiSelenium11.Data;
using ReneiskiSelenium11.Data.Constants;
using ReneiskiSelenium11.PageObjects;
using ReneiskiSelenium11.PageObjects.Pages;

namespace ReneiskiSelenium11.Tests
{
    public class DemoQATests : BaseTest
    {

        [Test]
        public void FirstCheckBoxTest()
        {
            var check = new CheckBoxPage();

            GenericPages.CheckBoxPage.GoToCheckBoxPage();

            GenericPages.CheckBoxPage.ClickCheckBox();

            Assert.IsTrue(check.GetAttributeCheckBox());

            Assert.AreEqual(Constants.expectedText, check.GetTextResult());
        }

        [Test]
        public void SecondRadioButtonTest()
        {
            var buttonPage = new RadioButtonPage();

            GenericPages.RadioButtonPage.GoToRadioButtonPage();

            GenericPages.RadioButtonPage.YesRadioBtnClick();

            Assert.AreEqual("You have selected Yes", buttonPage.GetTextYesResult());

            GenericPages.RadioButtonPage.ImpRadioBtnClick();

            Assert.AreEqual("You have selected Impressive", buttonPage.GetTextYesResult());
        }

        [Test]
        public void ThirdWebTablesTest()
        {
            var webTablePage = new WebTablePage();

            GenericPages.WebTablePage.GoToWebTablesPage();

            Assert.AreEqual("Cierra", webTablePage.GetCellText(TestSettings.cCierra));
            Assert.AreEqual("Vega", webTablePage.GetCellText(TestSettings.cVega));
            Assert.AreEqual("39", webTablePage.GetCellText(TestSettings.cAge));
            Assert.AreEqual("cierra@example.com", webTablePage.GetCellText(TestSettings.cEmail));
            Assert.AreEqual("10000", webTablePage.GetCellText(TestSettings.cSalary));
            Assert.AreEqual("Insurance", webTablePage.GetCellText(TestSettings.cDepartament));

            GenericPages.WebTablePage.ClickAddButton();

            GenericPages.RegFormPage.EnterFirstName();
            GenericPages.RegFormPage.EnterLastName();
            GenericPages.RegFormPage.EnterUserEmail();
            GenericPages.RegFormPage.EnterAge();
            GenericPages.RegFormPage.EnterSalary();
            GenericPages.RegFormPage.EnterDepartment();

            GenericPages.WebTablePage.ClickSubmitButton();

            Assert.AreEqual($"{TestSettings.firstName}"+$"{TestSettings.lastName}"+$"{TestSettings.age}"+$"{TestSettings.userEmail}"+$"{TestSettings.salary}"+$"{TestSettings.department}", webTablePage.ReturnTextResult());

            GenericPages.WebTablePage.ClickEditButton();
            GenericPages.RegFormPage.ClearSalary();
            GenericPages.RegFormPage.EnterEditedSalary();
            GenericPages.WebTablePage.ClickSubmitButton();

            Assert.AreEqual($"{TestSettings.firstName}"+$"{TestSettings.lastName}"+$"{TestSettings.age}"+$"{TestSettings.userEmail}"+$"{TestSettings.editedUserSalary}"+$"{TestSettings.department}", webTablePage.ReturnTextResult());

            GenericPages.WebTablePage.ClickDeleteButton();
        }

        [Test]
        public void ForthButtonsTest()
        {
            var buttonPage = new ButtonPage();

            GenericPages.ButtonPage.GoToButtonsPage();

            GenericPages.ButtonPage.DoubleClick();
            Assert.AreEqual("You have done a double click", buttonPage.TextResult("doubleClickMessage"));

            GenericPages.ButtonPage.RightClick();
            Assert.AreEqual("You have done a right click", buttonPage.TextResult("rightClickMessage"));

            GenericPages.ButtonPage.DynamicClick();
            Assert.AreEqual("You have done a dynamic click", buttonPage.TextResult("dynamicClickMessage"));
        }

        [Test]
        public void FifthLinksTest()
        {
            var linksPage = new LinksPage();

            GenericPages.LinksPage.GoToLinksPage();

            GenericPages.LinksPage.ClickSimpleLink();

            WebDriverExtensions.SwitchToTheLastWindow();
            Assert.AreEqual(Constants.newUrl, linksPage.GetUrlAttribute());

            WebDriverExtensions.SwitchToTheFirstWindow();

            GenericPages.LinksPage.ClickCreated();
            Assert.AreEqual("Link has responded with staus 201 and status text Created", linksPage.TextResult("linkResponse"));

            GenericPages.LinksPage.ClickNoContent();
            var noContentButtonResultText = Driver.GetWebDriverWait().Until(drv => linksPage.TextResult("linkResponse") == Constants.noContent);

            Assert.IsTrue(noContentButtonResultText);
        }
    }
}