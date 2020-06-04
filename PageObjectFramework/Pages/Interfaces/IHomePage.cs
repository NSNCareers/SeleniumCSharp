namespace PageObjectFramework.Interfaces
{
    public interface IHomePage
    {
        T ClickOnRegisterLink<T>() where T : class;
        T ClickOnLoginLink<T>() where T : class;
        string GetPageTitel();
        bool VerifyElementDisplayed(string selector);
        T ClickOnLoginAppLink<T>() where T : class;
        T ClickOnPrivacyLink<T>() where T : class;
        T ClickOnHomeLink<T>() where T : class;
    }
}