@automated
#@web
Feature: viewListAgencyProjectSale
	I want to view list of project

Background: 
	Given the following account
	| email          | password | fullname  | phone      | address       | role |
	| admin12@ppc.com | admin   | marketing | 0123456789 | trần hưng đạo | 1    |

	And the following properties
	| PropertyName        | Avatar                  | Images   | Property Type | Content                                                                                | Street         | Ward        | District | Price | UnitPrice | Area  | BedRoom | BathRoom | ParkingPlace | Owner | Created_at | Created_post | Status   | Note | Updated_at |
	| PIS Top Apartment1 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | admin12@ppc.com  | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment2 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | admin12@ppc.com  | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment3 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | admin12@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	
Scenario: View List of Agency Project Sale
	When I am at Home page
	And I have navigate to login admin page
	Then I enter 'admin12@ppc.com' and 'admin'
	When I have navigate to View List of Project page sale
	Then I should see my own projects sale
	| PropertyName        |
	| PIS Top Apartment1 |
	| PIS Top Apartment2 |
	| PIS Top Apartment3 |
