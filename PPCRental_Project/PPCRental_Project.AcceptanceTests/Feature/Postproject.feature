Feature: PostProperty
	As a owner of property
	I want to post my property
	so that i can to sell property.

	
Background:
	Given the following account
	| email          | password | fullname   | phone      | address      | role |
	| user@ppc.com | user  | marketing2 | 0123456789 | trần hưng đạo | 1    |
	Given the following properties
	| PropertyName       | Avatar                  | Images    | Property Type | Content                                                                                | Street         | Ward        | District | Price | UnitPrice | Area  | BedRoom | BathRoom | ParkingPlace | Owner            | Created_at | Created_post | Status   | Note | Updated_at |
	| PIS Top Apartment1 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | user@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment2 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | user@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment3 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | user@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	
#//@mytagadd
Scenario: Post project successfully
	When I am at Home page
	Then I have navigate to Login page
	And I entered 'user@ppc.com' and 'user'
	When I have navigate to Post page
	And I entered the following information
	| PropertyName        | Avatar                  | Images   | Property Type | Content                                                                                | Street         | Ward        | District | Price | UnitPrice | Area  | BedRoom | BathRoom | ParkingPlace | Owner | Created_at | Created_post | Status   | Note | Updated_at |
	| PIS Top Apartment5 | PIS_6656-Edit-stamp.jpg  | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | user@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	And I have navigate to View List of Agency Project
	Then The list of properties shoul have my new property
	| PropertyName       | Avatar                  | Owner            | Price | Content                                                                                |
	| PIS Top Apartment1 | PIS_6656-Edit-stamp.jpg | user@ppc.com   | 10000 | The surrounding neighborhood is very much localized with a great number of local shops |
	| PIS Top Apartment2 | PIS_6656-Edit-stamp.jpg | user@ppc.com   | 10000 | The surrounding neighborhood is very much localized with a great number of local shops |
	| PIS Top Apartment3 | PIS_6656-Edit-stamp.jpg | user@ppc.com   | 10000 | The surrounding neighborhood is very much localized with a great number of local shops |
	| PIS Top Apartment5 | PIS_6656-Edit-stamp.jpg | user@ppc.com   | 10000 | The surrounding neighborhood is very much localized with a great number of local shops |