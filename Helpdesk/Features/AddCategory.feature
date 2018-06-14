Feature: Add Ticket Categories
	In order to Add Categories
	As a Admin
	I want to be able to create a new Ticket Category

@Add Ticket Categories
Scenario: Create New Caregory
	Given I am on Helpdesk page
	When I click on Administration tab
	And I Click on Ticket Categories 
	Then I should see Add Category button present
	When I Click the Add Category button
	Then I should see the Create form
	When I enter the details 
	| Category name | Section  |
	| Test  | Testuser_ |
	And Click on add new Category button
	Then the new category should be added successfully
