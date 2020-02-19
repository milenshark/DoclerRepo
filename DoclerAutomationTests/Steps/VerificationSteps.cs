using DoclerAutomationFramework.Base;
using DoclerAutomationTests.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DoclerAutomationTests.Steps
{
    [Binding]
    internal class VerificationSteps : BaseStep
    {
        [Then(@"The webpage title should be ""(.*)""")]
        public void ThenTheWebPageTitleShouldBe(string expectedPageTitle)
        {
            var actualPageTitle = OnCurrentPage.As<MainPage>().WebPageTitle;
            Assert.That(actualPageTitle, Is.EqualTo(expectedPageTitle),
                $"ERROR: Page title is incorrect: {actualPageTitle}");
        }

        [Then(@"The company logo should be visible")]
        public void ThenTheCompanyLogoShouldBeVisible()
        {
            Assert.That(OnCurrentPage.As<MainPage>().IsLogoDisplayed, Is.True, "ERROR: There is no logo on the page");
        }

        [Then(@"I should get navigated to the (.*) page")]
        public void ThenIShouldGetNavigatedToThePage(string pageName)
        {
            var actualAbsolutePath = OnCurrentPage.As<MainPage>().GetPageUrl().AbsolutePath;
            var errorMessage = $"ERROR: Actual absolute path is: {actualAbsolutePath}";

            switch (pageName.ToLower())
            {
                case "home":
                    StringAssert.Contains("/", actualAbsolutePath, errorMessage);
                    break;
                case "form":
                    StringAssert.Contains("/form.html", actualAbsolutePath, errorMessage);
                    break;
                case "error":
                    StringAssert.Contains("/error", actualAbsolutePath, errorMessage);
                    break;
                case "hello":
                    StringAssert.Contains("/hello.html", actualAbsolutePath, errorMessage);
                    break;
                default:
                    throw new Exception($"ERROR: there is no such page: {pageName}");
            }
        }

        [Then(@"It should turn to active status")]
        public void ThenItShouldTurnToActiveStatus()
        {
            Type t = OnCurrentPage.GetType();
            if (t.Equals(typeof(HomePage)))
            {
                Assert.That(OnCurrentPage.As<HomePage>().IsHomeMenuButtonActive, Is.True, "ERROR: Home Menu button is not active");
            }
            else if (t.Equals(typeof(FormPage)))
            {
                Assert.That(OnCurrentPage.As<FormPage>().IsFormMenuButtonActive, Is.True, "ERROR: Form Menu button is not active");
            }
            else if (t.Equals(typeof(ErrorPage)))
            {
                Assert.That(OnCurrentPage.As<ErrorPage>().IsErrorMenuButtonActive, Is.True, "ERROR: Error Menu button is not active");
            }
            else
            {
                throw new Exception("ERROR: Your page is undefined");
            }
        }
    }
}
