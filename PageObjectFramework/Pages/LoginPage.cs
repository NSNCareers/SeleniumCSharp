using CoreFramework.BaseClasses;
using OpenQA.Selenium;
using PageObjectFramework.Pages.Interfaces;

namespace PageObjectFramework.Pages
{
    public class LoginPage : BaseClass, ILoginPage
    {
        private static string pageName = "LoginPage";
        private static By locator = By.CssSelector("#Input_Email");

        public LoginPage() : base(pageName, locator)
        {
        }
    }
}
