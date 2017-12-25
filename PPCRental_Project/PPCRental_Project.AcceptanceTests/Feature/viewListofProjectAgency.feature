@automated
#@web
Feature: ViewLisofAgency
	I want to view list of project

Background: 
	Given the following account
	| email          | password | fullname  | phone      | address       | role |
	| user10@ppc.com | user   | marketing | 0123456789 | trần hưng đạo | 1    |

	And the following properties
	| PropertyName        | Avatar                  | Images   | Property Type | Content                                                                                | Street         | Ward        | District | Price | UnitPrice | Area  | BedRoom | BathRoom | ParkingPlace | Owner | Created_at | Created_post | Status   | Note | Updated_at |
	| PIS Top Apartment 1 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | user10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment 2 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | user10@ppc.com  | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment 3 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | user10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	
Scenario: View List of Project
	When I am at Home page
	Then I have navigate to Login page
	And I entered 'user10@ppc.com' and 'user'
	When I have navigate to View List of Project page
	Then I should see my own projects
	| PropertyName        |
	| PIS Top Apartment 1 |
	| PIS Top Apartment 2 |
	| PIS Top Apartment 3 |
