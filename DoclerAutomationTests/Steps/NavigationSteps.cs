using DoclerAutomationFramework.Base;
using DoclerAutomationFramework.Config;
using DoclerAutomationTests.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DoclerAutomationTests.Steps
{
    [Binding]
    internal class NavigationSteps : BaseStep
    {
        [Given(@"I have opened the tested webpage")]
        public void GivenIHaveOpenedTheTestedWebPage()
        {
            NavigateSite();
            OnCurrentPage = GetInstance<MainPage>();
        }

        [Given(@"I click (.*) menu")]
        [When(@"I click (.*) menu")]
        public void WhenIClickMenuButton(string menuButton)
        {
            switch (menuButton.ToLower())
            {
                case "home":
                    OnCurrentPage = OnCurrentPage.As<MainPage>().NavigateToHome();
                    break;
                case "error":
                    OnCurrentPage = OnCurrentPage.As<MainPage>().NavigateToError();
                    break;
                case "form":
                    OnCurrentPage = OnCurrentPage.As<MainPage>().NavigateToForm();
                    break;
                case "go":
                    OnCurrentPage = OnCurrentPage.As<FormPage>().SubmitForm();
                    break;
                case "ui testing":
                    OnCurrentPage = OnCurrentPage.As<MainPage>().NavigateToMain();
                    break;
                default:
                    throw new Exception($"ERROR: There is no such item in the menu: {menuButton}");
            }
        }

        [When(@"I open the (.*) page")]
        public void WhenIOpenThePage(string pageName)
        {
            switch (pageName.ToLower())
            {
                case "home":
                    DriverContext.Driver.Navigate().GoToUrl(Settings.AUT);
                    OnCurrentPage = GetInstance<HomePage>();
                    break;
                case "form":
                    DriverContext.Driver.Navigate().GoToUrl(Settings.AUT + "/form.html");
                    OnCurrentPage = GetInstance<FormPage>();
                    break;
                case "error":
                    DriverContext.Driver.Navigate().GoToUrl(Settings.AUT + "/error");
                    OnCurrentPage = GetInstance<ErrorPage>();
                    break;
                case "hello":
                    DriverContext.Driver.Navigate().GoToUrl(Settings.AUT + "/hello.html");
                    OnCurrentPage = GetInstance<HelloPage>();
                    break;
                default:
                    throw new Exception($"ERROR: There is no such page: {pageName}");
            }
        }
    }
}
