namespace PageObjectFramework.Pages.Interfaces
{
    public interface IRegisterConfirmationPage
    {
        string GetPageTitel();
        bool VerifyElementDisplayed(string selector);
        T ClickOnLoginAppLink<T>() where T : class;
        bool VerifyEmailText(string emailText);

    }
}
