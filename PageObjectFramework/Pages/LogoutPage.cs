using CoreFramework.BaseClasses;
using OpenQA.Selenium;
using PageObjectFramework.Pages.Interfaces;

namespace PageObjectFramework.Pages
{
    public class LogoutPage : BaseClass, ILogoutPage
    {
        private static string pageName = "LogoutPage";
        private static By locator = By.CssSelector("main>header>p");

        public LogoutPage() : base(pageName, locator)
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

        public T ClickOnLoginAppLink<T>() where T : class
        {
            var locator = By.CssSelector("a[class*='navbar-brand']");
            ClickOnElement(locator);
            return GetPage<T>();
        }

        public bool VerifyLogoutText(string emailText)
        {
            var locator = By.CssSelector("main>header>p");
            var boolResults = DoesElementContainText(locator, emailText);
            return boolResults;
        }

        public void Shutown()
        {
            ClosePage();
        }
    }
}
