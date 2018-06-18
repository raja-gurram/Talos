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
        public void VerifyHelpdeskPage()
        {
            Assert.IsTrue(driver.Title.Contains("Helpdesk"));
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
        public Func<IWebDriver, bool> IsElementPresent(IWebElement element)
        {
            return driver =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            };
        }

        public void WaitForElement(IWebElement ele)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(IsElementPresent(ele));
        }

        public void VerifyAddNewCategoryButton()
        {
            WaitForElement(AddNewCategoryButton);
            Assert.IsTrue(AddNewCategoryButton.Displayed);
        }

        public void ClickOnAddNewCategory()
        {
            AddNewCategoryButton.Click();
        }
        public void VerifyCreateNewCategoryForm()
        {
            Assert.IsTrue(CategoryName.Displayed);
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void EnterDetails(Table table)
        {
            var CategoryName = table.Rows[0][0];
           //CategoryName.SendKeys(CategoryName + RandomString(4) );
           

        }

        public void EnterDetails()
        {
            CategoryName.SendKeys("NEW Category" + RandomString(20));
            var Section = driver.FindElement(By.Name("Section"));
            //create select element object 
            var selectElement = new SelectElement(Section);

            //select by value
            selectElement.SelectByValue("Sales");
            // select by text
            selectElement.SelectByText("Technical");
        }

        public void ClickOnCreateCategoryButton()
        {
           AddNewCategory.Click();
        }

      

    }
}
