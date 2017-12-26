@automation
Feature: Filter
	I am a user
	I want to search property with element i chosen
	So that I can see property with i want


Background: 
	Given the following property
	| PropertyName       | Avatar                  | Images    | Property Type | Content                                                                                | Street         | Ward        | District	 | Price | UnitPrice | Area  | BedRoom | BathRoom | ParkingPlace | Owner            | Created_at | Created_post | Status   | Note | Updated_at |
	| PIS Top Apartment  | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Đông Du        | P.Bến Nghé  | Q.1		 | 10000 | USD       | 120m2 | 3       | 3        | 1            | sale10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| ViLa Q1            | PIS_6656-Edit-stamp.jpg | test.jpg, | Villa         | The surrounding neighborhood is very much localized with a great number of local shops | Đông Du        | P.Bến Nghé  | Q.1		 | 10000 | USD       | 120m2 | 3       | 3        | 1            | sale10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment3 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Bạch Đằng      | P.1         | Q.Bình Thạnh| 10000 | USD       | 120m2 | 3       | 3        | 1            | sale10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |

Scenario: Filter district
	When I input 'Q.1' to district filter into Homepage
	Then I should see property
	| PropertyName								   |
	| PIS Top Apartment                            |
	| ViLa Q1                                      |

Scenario: Filter property type
	When I input 'Apartment' to propertytype field and click search into Homepage
	Then I should see property with type is Apartment
	| PropertyName								   |
	| PIS Top Apartment                            |
	| PIS Top Apartment3                           |

Scenario: Filter with two element
	When I input 'Q.1' in district field and 'Apartment' in property_type field and click search into Homepage
	Then I should see property list
	| PropertyName								   |
	| PIS Top Apartment                            |

Scenario: Filter with three element
	When I input 'Q.1' in district field, 'Apartment' in property_type field, chosen bed room '3' click search into Homepage
    Then I should see property in district1 and type is Apartment and have 2bedroom
	| PropertyName								   |
	| PIS Top Apartment                            |