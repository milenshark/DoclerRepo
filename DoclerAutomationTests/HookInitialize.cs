using DoclerAutomationFramework.Base;
using TechTalk.SpecFlow;

namespace DoclerAutomationTests
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {

        public HookInitialize()
        {
            InitializeSettings();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

        [AfterFeature]
        public static void TestShutDown()
        {
            DriverContext.Driver.Quit();
        }
    }
}
