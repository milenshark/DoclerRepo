using DoclerAutomationFramework.Base;
using DoclerAutomationTests.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DoclerAutomationTests.Steps

{
    [Binding]
    internal class HomePageSteps : BaseStep
    {
        [StepDefinition(@"I see (.*) in (.*) tag")]
        public void ThenISeeTextInHTag(string text, string expectedTagName)
        {
            var actualTagName = OnCurrentPage.As<HomePage>().GetContainterTagName(text);
            Assert.That(actualTagName, Is.EqualTo(expectedTagName),
                $"ERROR: The text is wrapped by another tag: {actualTagName}");
        }
    }
}
