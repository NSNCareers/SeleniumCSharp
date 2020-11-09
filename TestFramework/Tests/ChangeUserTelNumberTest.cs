using CoreFramework.BrowserConfig;
using NUnit.Framework;
using PageObjectFramework.Interfaces;
using PageObjectFramework.IOC;
using PageObjectFramework.Pages;
using PageObjectFramework.Pages.Interfaces;
using PageObjectFramework.StartUpConfig;
using System;

namespace TestFramework.Tests
{
    [TestFixture()]
    [Parallelizable]
    public class ChangeUserTelNumberTest : StartUpClass
    {
        private IHomePage _homePage;
        private ILoginPage _loginPage;
        private IUserAccountPage _userAccountPage;
        private ILogoutPage _logoutPage;
        private Random _random;
        private int telNumber;
        private string newEmail;

        [OneTimeSetUp]
        public void SetUp()
        {
            _homePage = UnityWrapper.Resolve<IHomePage>();

            _random = new Random();
            telNumber = _random.Next(100000, 200000000);
            var value = _random.Next(100, 20000);
            _loginPage = _homePage.ClickOnLoginLink<LoginPage>();

            var email = "snscareers@yahoo.com";
            var password = "Password01#";
            newEmail = $"snscareers{value}@yahoo.com";
            _loginPage.EnterEmail(email);
            _loginPage.EnterPassword(password);
            _loginPage.CheckRememberMeRadioButton();
            _userAccountPage = _loginPage.ClickOnlogInButton<UserAccountPage>();
        }



        [Test, Category("Login logout User")]
        public void AssertPageTitel()
        {
            var titel = _userAccountPage.GetPageTitel();
            var pageTitel = "Home page - LoginApp";
            Assert.AreEqual(titel,pageTitel);
        }

        [Test, Category("Login logout User")]
        public void ClickOnUserEmail()
        {
           _userAccountPage.ClickOnUserEmail();
        }

        [Test, Category("Login logout User")]
        public void EnterOrChangeUserNumber()
        {
            _userAccountPage.EnterTelephoneNumber(telNumber.ToString());
            _userAccountPage.ClickOnSaveButton();

            var text = "×\r\nYour profile has been updated";
            var boolResults = _userAccountPage.VerifyProfileText(text);
            Assert.IsTrue(boolResults, "Element does not contain text");

            _userAccountPage.Shutown();
        }

        [Test, Category("Login logout User")]
        public void EnterOrChangeUsersNumber()
        {
            _userAccountPage.ClickEmailButton();
            _userAccountPage.EnterNewEmail(newEmail);
            _userAccountPage.ClickOnChangeEmailButton();

            var text = "×\r\nConfirmation link to change email sent. Please check your email.";
            var boolResults = _userAccountPage.VerifyManageEmailText(text);
            Assert.IsTrue(boolResults, "Element does not contain text");
        }

        [Test, Category("Login logout User")]
        public void LogUserOut()
        {
            _logoutPage = _userAccountPage.ClickOnLogoutButton<LogoutPage>();
            var titel = _logoutPage.GetPageTitel();
            var pageTitel = "Log out - LoginApp";
            Assert.AreEqual(titel, pageTitel);
        }

    }
}
