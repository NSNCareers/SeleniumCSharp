using CoreFramework.BaseClasses;
using OpenQA.Selenium;
using PageObjectFramework.Pages.Interfaces;

namespace PageObjectFramework.Pages
{
    public class LoginPage : BaseClass, ILoginPage
    {
        private static string pageName = "LoginPage";
        private static By locator = By.CssSelector("label[for='Input_RememberMe']");

        public LoginPage() : base(pageName, locator)
        {

        }

        public string GetPageTitel()
        {
            var titel = driver.Title;

            return titel;
        }

        public bool VerifyElementDisplayed(string selector)
        {
            var locator = By.CssSelector(selector);
            var boolResults = IsElementDisplayed(locator);
            return boolResults;
        }

        public void EnterEmail(string email)
        {
            var locator = By.CssSelector("input[type='email']");
            EnterText(locator, email);
        }

        public void EnterPassword(string password)
        {
            var locator = By.CssSelector("input[id='Input_Password']");
            EnterText(locator, password);
        }

        public T ClickOnlogInButton<T>() where T : class
        {
            var locator = By.CssSelector("div>button[type='submit']");
            ClickOnElement(locator);
            return GetPage<T>();
        }

        public void CheckRememberMeRadioButton() 
        {
            var locator = By.CssSelector("input[type='checkbox']");
            ClickOnElement(locator);
        }

        public T ClickOnForgotYourPasswordLink<T>() where T : class
        {
            var locator = By.CssSelector("a[id='forgot-password']");
            ClickOnElement(locator);
            return GetPage<T>();
        }

        public T ClickOnRegisterAsANewUserLink<T>() where T : class
        {
            var locator = By.CssSelector("a[href*='/Register?']");
            ClickOnElement(locator);
            return GetPage<T>();
        }

        public T ClickOnResendEmailConfirmationLink<T>() where T : class
        {
            var locator = By.CssSelector("p>button[type='submit']");
            ClickOnElement(locator);
            return GetPage<T>();
        }
    }
}
