using DoclerAutomationFramework.Base;
using DoclerAutomationTests.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DoclerAutomationTests.Steps
{
    [Binding]
    internal class HelloPageSteps : BaseStep
    {
        [Then(@"I see following text (.*)")]
        public void ThenISeeFollowingText(string expectedText)
        {
            var actualText = OnCurrentPage.As<HelloPage>().GetPageHeader();
            Assert.That(actualText, Is.EqualTo(expectedText),
                $"ERROR: Page header is different: {actualText}");
        }
    }
}
