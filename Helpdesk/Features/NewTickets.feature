Feature: NewTickets
	In order to Assign Tickets
	As a Admin
	I want to be able to create a new Ticket 


@NewTickets
Scenario: Create New Tickets
	Given I am on Helpdesk page
	When I click on New Ticket Button
    Then I should see the New Ticket form
	When I enter the details 
	| Subject | Description  | Category | Priority |
	| Ticket1  | First | Tecnichal     | High    | 
	And Click on Submit button
	Then the User Ticket should be generated successfully