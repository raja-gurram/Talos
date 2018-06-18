Feature: Add Ticket Categories
	In order to Add Categories
	As a Admin
	I want to be able to create a new Ticket Category

@Add Ticket Categories
Scenario: Create New Category
	Given I am on Helpdesk page
	When I click on Administration tab
	And I Click on Ticket Categories 
	Then I should see Add Category button present
	When I Click the Add Category button
	Then I should see the Create New Category form
	When I enter the Category Details 
	| Category name | Section  |
	Then Click on add new Category button
	
