using DoclerAutomationFramework.Base;
using DoclerAutomationTests.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DoclerAutomationTests.Steps
{
    [Binding]
    internal class FormPageSteps : BaseStep
    {
        [Then(@"I see (.*) of (.*) field")]
        public void ThenISeeFields(int expectedNumber, string fieldType)
        {
            string field = "";
            if (fieldType.Equals("input", System.StringComparison.CurrentCulture))
            {
                field = "input";
            }
            else if (fieldType.Equals("submit", System.StringComparison.CurrentCulture))
            {
                field = "button[@type='submit']";
            }
            var actualNumber = OnCurrentPage.As<FormPage>().GetNumberOfVisibleElements(field);

            Assert.That(actualNumber, Is.EqualTo(expectedNumber),
                $"ERROR: Incorrect Number of {fieldType} elements: {actualNumber}");
        }

        [When(@"I type (.*) the input field")]
        public void WhenITypeTheInputField(string text)
        {
            OnCurrentPage.As<FormPage>().TypeName(text);
        }

        [When(@"I submit the form")]
        public void WhenISubmitTheForm()
        {
            OnCurrentPage = OnCurrentPage.As<FormPage>().SubmitForm();
        }
    }
}
