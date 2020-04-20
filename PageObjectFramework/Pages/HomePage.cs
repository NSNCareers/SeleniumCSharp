using CoreFramework.BaseClasses;
using OpenQA.Selenium;
using PageObjectFramework.Interfaces;

namespace PageObjectFramework.Pages
{
    public class HomePage : BaseClass, IHomePage
    {
        private static string pageName = "HomePage";
        private static By locator = By.CssSelector("nav[class*='expand']>div>a[class*='brand']");

        public HomePage() : base(pageName, locator)
        {
        }


        public string GetPageTitel()
        {
            var titel = driver.Title;

            return titel;
        }
       

        public T ClickOnRegisterLink<T>() where T:class
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
    }
}
