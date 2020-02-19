using OpenQA.Selenium;

namespace DoclerAutomationTests.Pages
{
    public class HomePage : MainPage
    {
        public bool IsHomeMenuButtonActive()
        {
            return IsMenuButtonActive(HomePageButton);
        }

        public string GetContainterTagName(string text)
        {
            var element = _driver.FindElement(By.XPath($"//*[contains(text(), '{text}')]"));
            return element.TagName;
        }

    }
}