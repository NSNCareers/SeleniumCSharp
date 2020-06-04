using CoreFramework.BaseClasses;
using OpenQA.Selenium;
using PageObjectFramework.Interfaces;

namespace PageObjectFramework.Pages
{
    public class HomePage : BaseClass, IHomePage
    {
        private static string pageName = "HomePage";
        private static By locator = By.CssSelector("main>div>h1[class='display-4']");

        public HomePage() : base(pageName, locator)
        {
        }


        public string GetPageTitel()
        {
            var titel = driver.Title;

            return titel;
        }
       

        public T ClickOnRegisterLink<T>() where T: class
        {
            var locator = By.CssSelector("a[href*='Register']");
            ClickOnElement(locator);
            return GetPage<T>();
        }

        public T ClickOnLoginLink<T>() where T : class
        {
            var locator = By.CssSelector("a[href*='Login']");
            ClickOnElement(locator);
            return GetPage<T>();
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

        public T ClickOnHomeLink<T>() where T : class
        {
            var locator = By.CssSelector("ul>li>a[href='/']");
            ClickOnElement(locator);
            return GetPage<T>();
        }

        public T ClickOnPrivacyLink<T>() where T : class
        {
            var locator = By.CssSelector("li>a[href='/Privacy']");
            ClickOnElement(locator);
            return GetPage<T>();
        }
    }
}
