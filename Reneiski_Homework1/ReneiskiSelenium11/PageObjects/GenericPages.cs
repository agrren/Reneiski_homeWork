using ReneiskiSelenium11.PageObjects.Pages;

namespace ReneiskiSelenium11.PageObjects
{
    public static class GenericPages
    {
        public static BasePage BasePage => GetPage<BasePage>();
        public static ButtonPage ButtonPage => GetPage<ButtonPage>();
        public static CheckBoxPage CheckBoxPage => GetPage<CheckBoxPage>();
        public static LinksPage LinksPage => GetPage<LinksPage>();
        public static RadioButtonPage RadioButtonPage => GetPage<RadioButtonPage>();
        public static WebTablePage WebTablePage => GetPage<WebTablePage>();
        public static RegFormPage RegFormPage => GetPage<RegFormPage>();

        private static T GetPage<T>() where T : new() => new T();
    }
}
