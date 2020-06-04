namespace PageObjectFramework.Interfaces
{
    public interface IRegisterPage
    {
        string GetPageTitel();
        bool VerifyElementDisplayed(string selector);
        T ClickOnSubmitButton<T>() where T : class;
        void EnterEmail(string email);
        void EnterPassword(string password);
        void EnterConfirmPassword(string confirmPassword);
    }
}