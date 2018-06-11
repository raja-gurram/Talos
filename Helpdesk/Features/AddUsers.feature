Feature: AddUsers
	In order to Add Users
	As a Admin
	I want to be able to create and give permissions to users

@AddUsers
Scenario: Adding up/Create Users Accounts
	Given I am on Helpdesk page
	When I click on Administration tab
	And I Click on Users and permissions link 
	Then I should see Add User button present
	When I Click the Add user button
	Then I should see the Create form
	When I enter the details 
	| Email | Username  | Firstname | Lastname | Company | Password |
	| Test  | Testuser_ | bruce     | wayne    | SQA     | 12345678 |
	And Click on Create button
	Then the User account should be generated successfully
