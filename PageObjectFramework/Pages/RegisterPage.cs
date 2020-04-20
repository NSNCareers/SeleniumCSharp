using System;
using CoreFramework.BaseClasses;
using OpenQA.Selenium;
using PageObjectFramework.Interfaces;

namespace PageObjectFramework.Pages
{
    public class RegisterPage : BaseClass, IRegisterPage
    {
        private static string pageName = "RegisterPage";
        private static By locator = By.CssSelector("#Input_ConfirmPassword");

        public RegisterPage() : base(pageName, locator)
        {
        }

        public string GetPageTitel()
        {
            var titel = driver.Title;

            return titel;
        }
    }
}
