namespace PageObjectFramework.Pages.Interfaces
{
    public interface ILoginPage
    {
        string GetPageTitel();
        bool VerifyElementDisplayed(string selector);
        void EnterEmail(string email);
        void EnterPassword(string password);
        T ClickOnlogInButton<T>() where T : class;
        void CheckRememberMeRadioButton();
        T ClickOnForgotYourPasswordLink<T>() where T : class;
        T ClickOnRegisterAsANewUserLink<T>() where T : class;
        T ClickOnResendEmailConfirmationLink<T>() where T : class;
    }
}
