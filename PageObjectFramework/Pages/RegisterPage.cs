using CoreFramework.BaseClasses;
using OpenQA.Selenium;
using PageObjectFramework.Interfaces;

namespace PageObjectFramework.Pages
{
    public class RegisterPage : BaseClass, IRegisterPage
    {
        private static string pageName = "RegisterPage";
        private static By locator = By.CssSelector("button[type='submit']");

        public RegisterPage() : base(pageName, locator)
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

        public T ClickOnSubmitButton<T>() where T : class
        {
            var locator = By.CssSelector("button[type='submit']");
            ClickOnElement(locator);
            return GetPage<T>();
        }

        public void EnterEmail(string email) 
        {
            var locator = By.CssSelector("input[type='email']");
            EnterText(locator,email);
        }

        public void EnterPassword(string password)
        {
            var locator = By.CssSelector("input[id='Input_Password']");
            EnterText(locator, password);
        }

        public void EnterConfirmPassword(string confirmPassword)
        {
            var locator = By.CssSelector("input[id='Input_ConfirmPassword']");
            EnterText(locator, confirmPassword);
        }
    }
}
