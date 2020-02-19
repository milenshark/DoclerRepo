using OpenQA.Selenium;

namespace DoclerAutomationTests.Pages
{
    public class HelloPage : MainPage
    {
        private IWebElement PageHeader => _driver.FindElement(By.TagName("h1"));

        public string GetPageHeader()
        {
            return PageHeader.Text;
        }
    }
}
