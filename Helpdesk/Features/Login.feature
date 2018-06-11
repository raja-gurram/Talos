Feature: Login users in jitbit
	In order to access the Jitbit website 
	As a User
	I want to be able to login successfully

@Login
Scenario: Verify Login functionality

	Given I am on the LoginPage
	When I enter Username and password
	And click on the Login button
	Then I should be able to login successfully
	