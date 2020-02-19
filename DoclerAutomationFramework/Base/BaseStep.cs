using DoclerAutomationFramework.Config;

namespace DoclerAutomationFramework.Base
{
    public abstract class BaseStep : Base
    {
        public virtual void NavigateSite()
        {
            DriverContext.Driver.Navigate().GoToUrl(Settings.AUT);
        }
    }
}
