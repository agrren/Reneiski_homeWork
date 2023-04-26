using Microsoft.Extensions.Configuration;
using ReneiskiSelenium11.Data.Enums;

namespace ReneiskiSelenium11.Data
{
    public class TestSettings
    {
        public static Browsers Browser { get; set; }
        public static string cCierra { get; set; }
        public static string cVega { get; set; }
        public static string cAge { get; set; }
        public static string cEmail { get; set; }
        public static string cSalary { get; set; }
        public static string cDepartament { get; set; }
        public static string PageUrl { get; set; }
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string userEmail { get; set; }
        public static string age { get; set; }
        public static string salary { get; set; }
        public static string department { get; set; }
        public static string editedUserSalary { get; set; }


        static IConfiguration TestConfiguration { get; } = new ConfigurationBuilder().AddJsonFile("testsettings.json").Build();

        static TestSettings()
        {
            Enum.TryParse(TestConfiguration["Common:Browser"], out Browsers browser);
            Browser = browser;
            cCierra = TestConfiguration["ColumnName:cCierra"];
            cVega = TestConfiguration["ColumnName:cVega"];
            cAge = TestConfiguration["ColumnName:cAge"];
            cEmail = TestConfiguration["ColumnName:cEmail"];
            cSalary = TestConfiguration["ColumnName:cSalary"];
            cDepartament = TestConfiguration["ColumnName:cDepartament"];
            PageUrl = TestConfiguration["Common:Urls:Page"];
            firstName = TestConfiguration["RegFormValue:firstname"];
            lastName = TestConfiguration["RegFormValue:lastname"];
            userEmail = TestConfiguration["RegFormValue:userEmail"];
            age = TestConfiguration["RegFormValue:age"];
            salary = TestConfiguration["RegFormValue:salary"];
            department = TestConfiguration["RegFormValue:department"];
            editedUserSalary = TestConfiguration["RegFormValue:editedUserSalary"];
        }
    }
}
