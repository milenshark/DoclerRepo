﻿using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DoclerAutomationFramework.Base
{
    public class Base
    {
        public BasePage OnCurrentPage
        {
            get
            {
                return (BasePage)ScenarioContext.Current["currentPage"];
            }
            set
            {
                ScenarioContext.Current["currentPage"] = value;
            }
        }

        protected IWebDriver _driver { get; set; }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
