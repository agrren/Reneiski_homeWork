
namespace ReneiskiSelenium11.Data.Constants
{
    public class Constants
    {
        public const string expectedText = "You have selected :\r\nhome\r\ndesktop\r\nnotes\r\ncommands\r\ndocuments\r\nworkspace\r\nreact\r\nangular\r\nveu\r\noffice\r\npublic\r\nprivate\r\nclassified\r\ngeneral\r\ndownloads\r\nwordFile\r\nexcelFile";
        public const string newUrl = "https://demoqa.com/";
        public const string noContent = "Link has responded with staus 204 and status text No Content";
        public const string xPath = "(//*[@class=\"rt-tr-group\"]//div[@role='row'])[1]//div[@role='gridcell'][count(//*[contains(text(),'{0}')]//ancestor::div[1]//preceding-sibling::div)]";
    }
}
