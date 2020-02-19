using DoclerAutomationFramework.Base;
using OpenQA.Selenium;
using System;

namespace DoclerAutomationTests.Pages
{
    public class MainPage : BasePage
    {
        protected IWebElement MainPageButton => _driver.FindElement(By.Id("site"));

        protected IWebElement HomePageButton => _driver.FindElement(By.Id("home"));

        protected IWebElement FormPageButton => _driver.FindElement(By.Id("form"));

        protected IWebElement ErrorPageButton => _driver.FindElement(By.Id("error"));

        protected IWebElement CompanyLogoImage => _driver.FindElement(By.Id("dh_logo"));

        public string WebPageTitle => _driver.Title;

        public bool IsLogoDisplayed => CompanyLogoImage.Displayed;

        public HomePage NavigateToHome()
        {
            HomePageButton.Click();
            return GetInstance<HomePage>();
        }

        public FormPage NavigateToForm()
        {
            FormPageButton.Click();
            return GetInstance<FormPage>();
        }

        public ErrorPage NavigateToError()
        {
            ErrorPageButton.Click();
            return GetInstance<ErrorPage>();
        }

        public HomePage NavigateToMain()
        {
            MainPageButton.Click();
            return GetInstance<HomePage>();
        }

        public Uri GetPageUrl()
        {
            return new Uri(_driver.Url);
        }

        protected bool IsMenuButtonActive(IWebElement element)
        {
            var classAttributeValue = element.FindElement(By.XPath("..")).GetAttribute("class");
            return classAttributeValue == "active";
        }

        public int GetNumberOfVisibleElements(string locator)
        {
            var numberOfVisibleElements = 0;
            foreach (var element in _driver.FindElements(By.XPath($"//{locator}")))
            {
                if (element.Displayed)
                {
                    numberOfVisibleElements++;
                }
            }
            return numberOfVisibleElements;
        }
    }
}
