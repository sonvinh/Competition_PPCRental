@automated
#@web

Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given the following account
	| email          | password | fullname  | phone      | address       | role | 
	| sale10@ppc.com | admin1   | marketing | 0123456789 | trần hưng đạo | 1    |

Scenario: Login successfully by selenium
	When I am at Home page
	Then I have navigate to Login page
	Then I entered 'sale10@ppc.com' and 'admin1'
	