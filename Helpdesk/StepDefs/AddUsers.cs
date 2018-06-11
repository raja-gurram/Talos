using Helpdesk.Driver;
using TechTalk.SpecFlow;

namespace Helpdesk.StepDefs
{
    [Binding]
    [Scope(Tag = "AddUsers")]
    public sealed class AddUsers : BaseClass
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

        [When(@"I Click on Users and permissions link")]
        public void WhenIClickOnUsersAndPermissionsLink()
        {
            AddUserPage.ClickOnUsersLink();
        }

        [Then(@"I should see Add User button present")]
        public void ThenIShouldSeeAddUserButtonPresent()
        {
            AddUserPage.VerifyAddUserButton();
        }

        [When(@"I Click the Add user button")]
        public void WhenIClickTheAddUserButton()
        {
            AddUserPage.ClickOnAddUser();
        }

        [Then(@"I should see the Create form")]
        public void ThenIShouldSeeTheCreateForm()
        {
            AddUserPage.VerifyCreateUserForm();
        }

        [When(@"I enter the details")]
        public void WhenIEnterTheDetails(Table table)
        {
            AddUserPage.EnterDetails(table);
        }

        [When(@"Click on Create button")]
        public void WhenClickOnCreateButton()
        {
            AddUserPage.ClickOnCreateButton();
        }

        [Then(@"the User account should be generated successfully")]
        public void ThenTheUserAccountShouldBeGeneratedSuccessfully()
        {
            AddUserPage.VerifyCreatedUser();
        }

    }
}
