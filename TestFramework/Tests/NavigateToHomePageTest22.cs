using NUnit.Framework;
using PageObjectFramework.Interfaces;
using PageObjectFramework.IOC;
using PageObjectFramework.Pages.Interfaces;
using PageObjectFramework.StartUpConfig;

namespace TestFramework.Tests
{
    [TestFixture()]
    public class NavigateToHomePageTest22 : StartUpClass
    {
        private IHomePage _homePage;
        private IRegisterPage _searchPage;
        private ILoginPage _loginPage;

        [OneTimeSetUp]
        public void SetUp()
        {
            _homePage = UnityWrapper.Resolve<IHomePage>();
        }

        [OneTimeTearDown]
        public void Teardown()
        {

        }



        [Test, Category("Navigate to Login Page")]
        public void AssertPageTitel()
        {
            var titel = _homePage.GetPageTitel();
            var pageTitel = "Home page - LoginApp";
            Assert.AreEqual(titel,pageTitel);
        }

        [Test, Category("Navigate to Login Page")]
        public void AssertRegisterButtonDisplayed()
        {
            var locator = "a[href*='Register']";
            var boolResults = _homePage.VerifyElementDisplayed(locator);
            Assert.IsTrue(boolResults,$"Register button is not displayed");
        }

        [Test, Category("Navigate to Login Page")]
        public void AssertLoginButtonDisplayed()
        {
            var locator = "a[href*='Login']";
            var boolResults = _homePage.VerifyElementDisplayed(locator);
            Assert.IsTrue(boolResults, $"Login button is not displayed");
        }
    }
}
