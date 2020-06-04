using PageObjectFramework.Interfaces;
using PageObjectFramework.Pages;
using PageObjectFramework.Pages.Interfaces;

namespace PageObjectFramework.IOC
{
    public static class ResolveDependency
    {
       public static void RegisterAndResolveDependencies()
        {

            UnityWrapper.Register<IHomePage, HomePage>();
            UnityWrapper.Register<IRegisterPage, RegisterPage>();
            UnityWrapper.Register<ILoginPage, LoginPage>();
            UnityWrapper.Register<ILogoutPage, LogoutPage>();
            UnityWrapper.Register<IRegisterConfirmationPage, RegisterConfirmationPage>();
            UnityWrapper.Register<IUserAccountPage, UserAccountPage>();
        }
    }
}
