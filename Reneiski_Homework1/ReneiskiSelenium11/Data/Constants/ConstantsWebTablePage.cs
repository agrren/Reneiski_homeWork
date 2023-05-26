
namespace ReneiskiSelenium11.Data.Constants
{
    public class ConstantsWebTablePage
    {
        public const string XPathToTableCell = "(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'{0}')]//ancestor::div[1]//preceding-sibling::div)]";
        public const string ColumnNameFirstName = "First Name";
        public const string ColumnNameLastName = "Last Name";
        public const string ColumnNameAge = "Age";
        public const string ColumnNameEmail = "Email";
        public const string ColumnNameSalary = "Salary";
        public const string ColumnNameDepartament = "Department";

    }
}
