Feature: Filter
		i can

@mytag
Scenario: Filter
	Given I in homepage
	And I choose district
	When I press filter
	Then the result show project in district i chosen
