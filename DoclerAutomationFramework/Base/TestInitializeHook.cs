using DoclerAutomationFramework.Config;
using OpenQA.Selenium.Chrome;

namespace DoclerAutomationFramework.Base
{
    public abstract class TestInitializeHook : Base
    {
        public void InitializeSettings()
        {
            ConfigReader.SetFrameworkSettings();
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Manage().Window.Maximize();

        }
    }
}
