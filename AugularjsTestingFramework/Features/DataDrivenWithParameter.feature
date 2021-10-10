Feature: DataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driver With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/register"
	And I click on Signup Button
	And I enter username  text "Mayababy"
	And I enter  my email address "mayababy@yahoo.com"
	And I enter  my password" PasswordSecure"
	When I click on the signup button
	Then I should be able to register successfully

