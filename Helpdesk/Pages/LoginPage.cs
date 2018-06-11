using Helpdesk.UrlEnums;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Helpdesk.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        private String baseUrl = "https://raja.jitbit.com/helpdesk/User/Login/";
        private String Username = "28rajag@gmail.com";
        private String Password = "Welcome1234";

        #region Elements

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement UsernameTextField { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PasswordTextField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#loginForm > table > tbody > tr:nth-child(5) > td > input")]
        public IWebElement LoginSubmit { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#spanLoggedIn > b > a")]
        public IWebElement PostLoginUsername { get; set; }


        #endregion

        #region Functions

        public void NavTo(String url)
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void EnterUsername(String username)
        {
            UsernameTextField.SendKeys(username);
        }

        public void EnterPassword(String password)
        {
            PasswordTextField.SendKeys(password);
        }

        public void EnterCredentials()
        {
            EnterUsername(Username);
            EnterPassword(Password);
        }

        public void ClickOnLogin()
        {
            LoginSubmit.Click();
        }

        public void VerifySuccessfulLogin()
        {
            Assert.IsTrue(PostLoginUsername.Text.ToLower().Equals(Username.ToLower()));
        }

        public void Login()
        {
            NavTo(baseUrl);
            EnterCredentials();
            ClickOnLogin();
            VerifySuccessfulLogin();
        }

        #endregion

    }
}

