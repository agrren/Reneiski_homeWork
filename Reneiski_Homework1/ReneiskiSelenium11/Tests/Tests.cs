using NUnit.Framework;
using ReneiskiSelenium11.Common.Extensions;
using ReneiskiSelenium11.Data;
using ReneiskiSelenium11.Data.Constants;
using ReneiskiSelenium11.PageObjects;
using ReneiskiSelenium11.PageObjects.Pages;
using ReneiskiSelenium11.Common.Drivers;
using ReneiskiSelenium11.Common.Extensions.ExtensionMethods;

namespace ReneiskiSelenium11.Tests
{
    public class DemoQATests : BaseTest
    {

        [Test]
        public void FirstCheckBoxTest()
        {
            GenericPages.MainPage.LeftMenuNavigationPanel.GoToCheckBoxPage();
            GenericPages.CheckBoxPage.ClickHomeCheckBox();
            Assert.IsTrue(GenericPages.CheckBoxPage.IsHomeCheckBoxChecked());
            Assert.AreEqual(CheckBoxPageConstants.SelectedHomeCheckboxExpectedMessage,
                StringExtension.ProcessStringBackspaces(GenericPages.CheckBoxPage.GetTextResultAfterHomeChecked()));
        }

        [Test]
        public void SecondRadioButtonTest()
        {
            GenericPages.MainPage.LeftMenuNavigationPanel.GoToRadioButtonPage();
            GenericPages.RadioButtonPage.ClickYesRadioButton();
            Assert.AreEqual("You have selected Yes", GenericPages.RadioButtonPage.GetTextResultAfterClick());

            GenericPages.RadioButtonPage.ClickImpressiveRadioButton();
            Assert.AreEqual("You have selected Impressive", GenericPages.RadioButtonPage.GetTextResultAfterClick());
        }

        [Test]
        public void ThirdWebTablesTest()
        {
            var FilledTableRawTextResult = string.Concat("Alex", "Ren", "41", "Ren@tut.by", "20000", "QA");
            var EditedTableRawTextResult = string.Concat("Alex", "Ren", "41", "Ren@tut.by", "22000", "QA");

            GenericPages.MainPage.LeftMenuNavigationPanel.GoToWebTablesPage();
            Assert.AreEqual("Cierra", GenericPages.WebTablePage.GetCellText(WebTablePageConstants.ColumnNameFirstName));
            Assert.AreEqual("Vega", GenericPages.WebTablePage.GetCellText(WebTablePageConstants.ColumnNameLastName));
            Assert.AreEqual("39", GenericPages.WebTablePage.GetCellText(WebTablePageConstants.ColumnNameAge));
            Assert.AreEqual("cierra@example.com", GenericPages.WebTablePage.GetCellText(WebTablePageConstants.ColumnNameEmail));
            Assert.AreEqual("10000", GenericPages.WebTablePage.GetCellText(WebTablePageConstants.ColumnNameSalary));
            Assert.AreEqual("Insurance", GenericPages.WebTablePage.GetCellText(WebTablePageConstants.ColumnNameDepartament));

            GenericPages.WebTablePage.ClickAddButton();

            GenericPages.RegistrationFormPage.EnterFirstName("Alex");
            GenericPages.RegistrationFormPage.EnterLastName("Ren");
            GenericPages.RegistrationFormPage.EnterUserEmail("Ren@tut.by");
            GenericPages.RegistrationFormPage.EnterAge("41");
            GenericPages.RegistrationFormPage.EnterSalary("20000");
            GenericPages.RegistrationFormPage.EnterDepartment("QA");

            GenericPages.WebTablePage.ClickSubmitButton();
            Assert.AreEqual(FilledTableRawTextResult, GenericPages.WebTablePage.ReturnTextResult());

            GenericPages.WebTablePage.ClickEditButton();
            GenericPages.RegistrationFormPage.ClearSalary();
            GenericPages.RegistrationFormPage.EnterEditedSalary("22000");
            GenericPages.WebTablePage.ClickSubmitButton();
            Assert.AreEqual(EditedTableRawTextResult, GenericPages.WebTablePage.ReturnTextResult());

            GenericPages.WebTablePage.ClickDeleteButton();
        }

        [Test]
        public void ForthButtonsTest()
        {
            GenericPages.MainPage.LeftMenuNavigationPanel.GoToButtonsPage();
            GenericPages.ButtonPage.DoubleClickDoubleClickButton();
            Assert.AreEqual("You have done a double click", GenericPages.ButtonPage.ReturnDoubleClickTextResult());

            GenericPages.ButtonPage.RightClickRightClickButton();
            Assert.AreEqual("You have done a right click", GenericPages.ButtonPage.ReturnRightClickTextResult());

            GenericPages.ButtonPage.DynamicClickDynamicClickButton();
            Assert.AreEqual("You have done a dynamic click", GenericPages.ButtonPage.ReturnDynamicClickTextResult());
        }

        [Test]
        public void FifthLinksTest()
        {
            GenericPages.MainPage.LeftMenuNavigationPanel.GoToLinksPage();
            GenericPages.LinksPage.ClickHomeLink();
            WebDriverExtensions.SwitchToTheLastWindow();

            Assert.AreEqual(TestSettings.PageUrl, GenericPages.LinksPage.GetCurrentPageUrl());

            WebDriverExtensions.SwitchToTheFirstWindow();
            GenericPages.LinksPage.ClickCreatedLink();
            Assert.AreEqual("Link has responded with staus 201 and status text Created", GenericPages.LinksPage.ReturnCreatedLinkTextResult());

            GenericPages.LinksPage.ClickNoContentLink();
            var isNoContentButtonResultText = IsNoContentButtonResultText(GenericPages.LinksPage);
            Assert.IsTrue(isNoContentButtonResultText);
        }

        private bool IsNoContentButtonResultText(LinksPage linksPage) => WebDriverFactory.Driver.GetWebDriverWait().Until(drv => linksPage.ReturnCreatedLinkTextResult() == LinksPageConstants.ClickedNoContentLinkExpectedMessage);
    }
}