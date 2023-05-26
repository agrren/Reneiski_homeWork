using NUnit.Framework;
using ReneiskiSelenium11.Common.Extensions;
using ReneiskiSelenium11.Data;
using ReneiskiSelenium11.Data.Constants;
using ReneiskiSelenium11.PageObjects;
using ReneiskiSelenium11.PageObjects.Pages;
using ReneiskiSelenium11.Common.Drivers;

namespace ReneiskiSelenium11.Tests
{
    public class DemoQATests : BaseTest
    {

        [Test]
        public void FirstCheckBoxTest()
        {
            var check = new CheckBoxPage();
            GenericPages.CheckBoxPage.GoToCheckBoxPage();
            GenericPages.CheckBoxPage.ClickHomeCheckBox();
            Assert.IsTrue(check.IsHomeCheckBoxChecked());
            Assert.AreEqual(ConstantsCheckBoxPage.SelectedHomeCheckboxExpectedMessage, check.GetTextResult());
        }

        [Test]
        public void SecondRadioButtonTest()
        {
            var buttonPage = new RadioButtonPage();
            GenericPages.RadioButtonPage.GoToRadioButtonPage();
            GenericPages.RadioButtonPage.ClickYesRadioButton();
            Assert.AreEqual("You have selected Yes", buttonPage.GetTextResult());

            GenericPages.RadioButtonPage.ClickImpressiveRadioButton();
            Assert.AreEqual("You have selected Impressive", buttonPage.GetTextResult());
        }

        [Test]
        public void ThirdWebTablesTest()
        {
            string FilledTableRawTextResult = string.Concat("Alex", "Ren", "41", "Ren@tut.by", "20000", "QA");
            string EditedTableRawTextResult = string.Concat("Alex", "Ren", "41", "Ren@tut.by", "22000", "QA");

            var webTablePage = new WebTablePage();

            GenericPages.WebTablePage.GoToWebTablesPage();
            Assert.AreEqual("Cierra", webTablePage.GetCellText(ConstantsWebTablePage.ColumnNameFirstName));
            Assert.AreEqual("Vega", webTablePage.GetCellText(ConstantsWebTablePage.ColumnNameLastName));
            Assert.AreEqual("39", webTablePage.GetCellText(ConstantsWebTablePage.ColumnNameAge));
            Assert.AreEqual("cierra@example.com", webTablePage.GetCellText(ConstantsWebTablePage.ColumnNameEmail));
            Assert.AreEqual("10000", webTablePage.GetCellText(ConstantsWebTablePage.ColumnNameSalary));
            Assert.AreEqual("Insurance", webTablePage.GetCellText(ConstantsWebTablePage.ColumnNameDepartament));

            GenericPages.WebTablePage.ClickAddButton();

            GenericPages.RegFormPage.EnterFirstName("Alex");
            GenericPages.RegFormPage.EnterLastName("Ren");
            GenericPages.RegFormPage.EnterUserEmail("Ren@tut.by");
            GenericPages.RegFormPage.EnterAge("41");
            GenericPages.RegFormPage.EnterSalary("20000");
            GenericPages.RegFormPage.EnterDepartment("QA");

            GenericPages.WebTablePage.ClickSubmitButton();
            Assert.AreEqual(FilledTableRawTextResult, webTablePage.ReturnTextResult());

            GenericPages.WebTablePage.ClickEditButton();
            GenericPages.RegFormPage.ClearSalary();
            GenericPages.RegFormPage.EnterEditedSalary("22000");
            GenericPages.WebTablePage.ClickSubmitButton();
            Assert.AreEqual(EditedTableRawTextResult, webTablePage.ReturnTextResult());

            GenericPages.WebTablePage.ClickDeleteButton();
        }

        [Test]
        public void ForthButtonsTest()
        {
            var buttonPage = new ButtonPage();
            GenericPages.ButtonPage.GoToButtonsPage();
            GenericPages.ButtonPage.DoubleClick();
            Assert.AreEqual("You have done a double click", buttonPage.ReturnDoubleClickTextResult());

            GenericPages.ButtonPage.RightClick();
            Assert.AreEqual("You have done a right click", buttonPage.ReturnRightClickTextResult());

            GenericPages.ButtonPage.DynamicClick();
            Assert.AreEqual("You have done a dynamic click", buttonPage.ReturnDynamicClickTextResult());
        }

        [Test]
        public void FifthLinksTest()
        {
            var linksPage = new LinksPage();
            GenericPages.LinksPage.GoToLinksPage();
            GenericPages.LinksPage.ClickHomeLink();
            WebDriverExtensions.SwitchToTheLastWindow();
            Assert.AreEqual(TestSettings.PageUrl, linksPage.GetUrlAttribute());

            WebDriverExtensions.SwitchToTheFirstWindow();
            GenericPages.LinksPage.ClickCreatedLink();
            Assert.AreEqual("Link has responded with staus 201 and status text Created", linksPage.ReturnCreatedLinkTextResult());

            GenericPages.LinksPage.ClickNoContentLink();
            var isNoContentButtonResultText = WebDriverFactory.Driver.GetWebDriverWait().Until(drv => linksPage.ReturnCreatedLinkTextResult() == ConstantsLinksPage.ClickedNoContentLinkExpectedMessage);
            Assert.IsTrue(isNoContentButtonResultText);
        }
    }
}