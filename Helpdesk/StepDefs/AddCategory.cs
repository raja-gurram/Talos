
using TechTalk.SpecFlow;
using Helpdesk.Driver;

using Helpdesk.Pages;

namespace Helpdesk.StepDefs
{
    [Binding]
    [Scope(Tag = "AddCategory")]
    public sealed class AddCategory: BaseClass

    {
        [Given(@"I am on Helpdesk page")]
        public void GivenIAmOnHelpdeskPage()
        {
            LoginPage.Login();
            AddUserPage.VerifyHelpdeskPage();
        }

        [When(@"I click on Administration tab")]
        public void WhenIClickOnAdministrationTab()
        {
            AddUserPage.ClickOnAdministrationTab();
        }
        


    }
}
