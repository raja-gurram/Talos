
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
            AddCategoryPage.VerifyHelpdeskPage();
        }

        [When(@"I click on Administration tab")]
        public void WhenIClickOnAdministrationTab()
        {
            AddUserPage.ClickOnAdministrationTab();
        }
        [When(@"I Click on Ticket Categories")]
        public void WhenIClickOnTicketCategories()
        {
            AddCategoryPage.ClickOnTicketCategories();
        }
        [Then(@"I should see Add Category button present")]
        public void ThenIShouldSeeAddCategoryButtonPresent()
        {
            AddCategoryPage.VerifyAddNewCategoryButton();
        }

        [When(@"I Click the Add Category button")]
        public void WhenIClickTheAddCategoryButton()
        {
            AddCategoryPage.ClickOnAddNewCategory();
        }

        [Then(@"I should see the Create New Category form")]
        public void ThenIShouldSeeTheCreateNewCategoryForm()
        {
            AddCategoryPage.VerifyCreateNewCategoryForm();
        }
        [When(@"I enter the Category Details")]
        public void WhenIEnterTheCategoryDetails(Table table)
        {
            AddCategoryPage.EnterDetails();
        }

        [When(@"Click on add new Category button")]
        public void WhenClickOnAddNewCategoryButton()
        {
            AddCategoryPage.ClickOnCreateCategoryButton();
        }
       
    }
}
