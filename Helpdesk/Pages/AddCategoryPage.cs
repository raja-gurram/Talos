using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace Helpdesk.Pages
{
    class AddCategoryPage
    {
        private IWebDriver driver;

        public AddCategoryPage(IWebDriver driver)
        {
            this.driver = driver;
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='divBigHeader']/ul[1]/li[5]/a")]
        public IWebElement AdministrationTab { get; set; }

        [FindsBy(How = How.Id, Using = "Categories")]
        public IWebElement TicketCategories { get; set; }

        [FindsBy(How = How.Id, Using = "btnNewCat")]
        public IWebElement AddNewCategoryButton { get; set; }

        [FindsBy(How = How.Name, Using = "categoryName")]
        public IWebElement CategoryName { get; set; }

        [FindsBy(How = How.Id, Using = "sectionSelect")]
        public IWebElement Section { get; set; }

        [FindsBy(How = How.Name, Using = "create")]
        public IWebElement AddNewCategory { get; set; }

        public void ClickOnTicketCategories()
        {
            TicketCategories.Click();
  
        }
        [Then(@"I should see Add Category button present")]
        public void ThenIShouldSeeAddCategoryButtonPresent()
        {
            ScenarioContext.Current.Pending();
        }
        [When(@"I Click the Add Category button")]
        public void WhenIClickTheAddCategoryButton()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
