namespace DoclerAutomationTests.Pages
{
    public class ErrorPage : MainPage
    {
        public bool IsErrorMenuButtonActive()
        {
            return IsMenuButtonActive(ErrorPageButton);
        }
    }
}
