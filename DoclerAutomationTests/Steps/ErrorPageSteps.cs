using DoclerAutomationFramework.Base;
using DoclerAutomationFramework.Utils;
using DoclerAutomationTests.Pages;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DoclerAutomationTests.Steps
{
    [Binding]
    internal class ErrorPageSteps : BaseStep
    {
        [Then(@"I should get ""(.*)"" HTTP response code")]
        public async Task ThenIShouldGetHTTPResponseCode(string expectedCode)
        {
            var url = OnCurrentPage.As<ErrorPage>().GetPageUrl();
            var actualHttpStatusCode = await HttpClientTools.GetHttpStatusCode(url);
            if (expectedCode == "404")
            {
                Assert.That(actualHttpStatusCode, Is.EqualTo(HttpStatusCode.NotFound),
                    $"ERROR: Http status code is different: {actualHttpStatusCode}");
            }
        }
    }
}
