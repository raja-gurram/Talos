using Helpdesk.UrlEnums;
using Helpdesk.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Helpdesk.Driver
{
    public class BaseClass : Hooks
    {


        #region Public Methods and Operators

        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();

        }

        internal LoginPage LoginPage => new LoginPage(driver);
        internal AddUserPage AddUserPage => new AddUserPage(driver);
        internal AddCategoryPage AddCategoryPage => new AddCategoryPage(driver);

        #endregion
    }
}

