@automated
#@web
Feature: LoginAdmin
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
Background:
	Given the following account:
	| email           | password | fullname  | phone      | address       | role | 
	| admin12@ppc.com | admin    | marketing | 0123456789 | trần hưng đạo | 0    |
Scenario: loginAdmin
	When I am at Home page
	And I have navigate to login admin page
	Then I enter 'admin12@ppc.com' and 'admin'
