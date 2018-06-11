using Helpdesk.Driver;
using System;
using TechTalk.SpecFlow;

namespace Helpdesk.StepDefs
{
    [Binding]
    [Scope(Tag = "Login")]
    public class LoginSteps : BaseClass
    {
        [Given(@"I am on the (.*)")]
        public void GivenIAmOnTheLoginPage(String url)
        {
            LoginPage.NavTo(url);
        }

        [When(@"I enter Username and password")]
        public void WhenIEnterUsernameAndPassword()
        {
            LoginPage.EnterCredentials();
        }

        [When(@"click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            LoginPage.ClickOnLogin();
        }

        [Then(@"I should be able to login successfully")]
        public void ThenIShouldBeAbleToLoginSuccessfully()
        {
            LoginPage.VerifySuccessfulLogin();
        }
    }
}
