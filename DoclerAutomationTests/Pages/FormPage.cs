using OpenQA.Selenium;

namespace DoclerAutomationTests.Pages
{
    public class FormPage : MainPage
    {
        private IWebElement NameInput => _driver.FindElement(By.Id("hello-input"));

        private IWebElement GoButton => _driver.FindElement(By.Id("hello-submit"));

        public bool IsFormMenuButtonActive()
        {
            return IsMenuButtonActive(FormPageButton);
        }

        public FormPage TypeName(string name)
        {
            NameInput.SendKeys(name);
            return this;
        }

        public HelloPage SubmitForm()
        {
            GoButton.Click();
            return GetInstance<HelloPage>();
        }
    }
}
