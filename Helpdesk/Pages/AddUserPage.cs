using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace Helpdesk.Pages
{
    public class AddUserPage
    {
        private IWebDriver driver;
        
        public AddUserPage(IWebDriver driver)
        {
            this.driver = driver;
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

       
        [FindsBy(How = How.XPath, Using = "//*[@id='divBigHeader']/ul[1]/li[5]/a")]
        public IWebElement AdministrationTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".maincontent > table:nth-child(2) > tbody > tr:nth-child(2) > td > div > a")]
        public IWebElement UsersLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div.maincontent > div:nth-child(1) > button:nth-child(1)")]
        public IWebElement AddUserButton { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement Firstname { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement Lastname { get; set; }

        [FindsBy(How = How.Id, Using = "fromCompanyId_txt")]
        public IWebElement Company { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "Signature")]
        public IWebElement SignatureTextField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".maincontent > form > table > tbody > tr:nth-child(10) > td:nth-child(2) > button")]
        public IWebElement CreateButton { get; set; }


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

        public void VerifyHelpdeskPage()
        {
            Assert.IsTrue(driver.Title.Contains("Helpdesk"));
        }

        public void ClickOnAdministrationTab()
        {
                WaitForElement(AdministrationTab);
                AdministrationTab.Click();
            }

        public void ClickOnUsersLink()
        {
            WaitForElement(UsersLink);
            UsersLink.Click();
        }

        public void VerifyAddUserButton()
        {
            WaitForElement(AddUserButton);
            Assert.IsTrue(AddUserButton.Displayed);
        }

        public void ClickOnAddUser()
        {
            AddUserButton.Click();
        }

        public void VerifyCreateUserForm()
        {
            Assert.IsTrue(Username.Displayed);
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
            var email = table.Rows[0][0];
            var username = table.Rows[0][1];
            var firstname = table.Rows[0][2];
            var lastname = table.Rows[0][3];
            var company = table.Rows[0][4];
            var password = table.Rows[0][5];

            WaitForElement(Email);
            Email.SendKeys(email+RandomString(4)+"@gmail.com");
            Username.Clear();
            Username.SendKeys(username+RandomString(4));
            Firstname.SendKeys(firstname+RandomString(4));
            Lastname.SendKeys(lastname+RandomString(4));
            Company.SendKeys(company);
            Password.SendKeys(password);
        }

        public void EnterDetails()
        {
            WaitForElement(Email);
            Email.SendKeys("Test" + RandomString(4) + "@gmail.com");
            Username.Clear();
            Username.SendKeys("Testuser_" + RandomString(4));
            Firstname.SendKeys("bruce" + RandomString(4));
            Lastname.SendKeys("wayne" + RandomString(4));
            Company.SendKeys("SQA");
            Password.SendKeys("12345678");
        }

        public void ClickOnCreateButton()
        {
            CreateButton.Click();
        }

        public void VerifyCreatedUser()
        {
            Assert.IsTrue(SignatureTextField.Displayed);
        }

        public void AddUsers()
        {
            VerifyHelpdeskPage();
            ClickOnAdministrationTab();
            ClickOnUsersLink();
            VerifyAddUserButton();
            ClickOnAddUser();
            VerifyCreateUserForm();
            EnterDetails();
            ClickOnCreateButton();
            VerifyCreatedUser();
        }

        public void AddUsers(int count)
        {
            while (count > 0)
            {
                AddUsers();
                count = count - 1;
            }
        }
    }
}
