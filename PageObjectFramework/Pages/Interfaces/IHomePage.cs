using PageObjectFramework.Pages.Interfaces;

namespace PageObjectFramework.Interfaces
{
    public interface IHomePage
    {
        T ClickOnRegisterLink<T>() where T : class;
        T ClickOnLoginLink<T>() where T : class;
        string GetPageTitel();
        bool VerifyElementDisplayed(string selector);
    }
}