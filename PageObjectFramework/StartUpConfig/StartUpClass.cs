using CoreFramework.BrowserConfig;
using NUnit.Framework;
using PageObjectFramework.Interfaces;
using PageObjectFramework.IOC;
using PageObjectFramework.Pages.Interfaces;

namespace PageObjectFramework.StartUpConfig
{
    [TestFixture]
    [Parallelizable]
    public class StartUpClass
    {
        public StartUpClass()
        {
        }

        [OneTimeSetUp]
        public void StartUp()
        {
            ResolveDependency.RegisterAndResolveDependencies();
            Session.StartBrowser();
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            Session.CloseBrowser();
        }

        #region Interfacce declarations

        public readonly IHomePage homePage;
        public readonly IRegisterPage searchPage;
        public readonly ILoginPage loginPage;
        public readonly ILogoutPage logoutPage;
        public readonly IRegisterConfirmationPage registerConfirmationPage;
        public readonly IUserAccountPage userAccountPage;

        #endregion
    }
}
