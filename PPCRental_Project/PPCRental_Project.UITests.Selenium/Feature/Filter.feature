Feature: Filter
		I am a user
	I want to search property with element i chosen
	So that I can see property with i want

@mytag
Scenario: Filter districts
	Given I in the homepage
	When I chosen 'Q.1' in district field and click search
	Then I will see list property'PIS Top Apartment,ViLa Q1 '
