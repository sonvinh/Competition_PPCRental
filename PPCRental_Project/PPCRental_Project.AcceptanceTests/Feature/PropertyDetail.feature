Feature: PropertyDetail
	As I want to see detail of a property
	So we can decide to bye this property

Background:
	Given the following account
	| email          | password | fullname   | phone      | address      | role |
	| sale10@ppc.com | admin1   | marketing2 | 0123456789 | trần hưng đạo | 1    |
	Given the following properties
	| PropertyName       | Avatar                  | Images    | Property Type | Content                                                                                | Street         | Ward        | District | Price | UnitPrice | Area  | BedRoom | BathRoom | ParkingPlace | Owner            | Created_at | Created_post | Status   | Note | Updated_at |
	| PIS Top Apartment1 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | sale10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment2 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | sale10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
	| PIS Top Apartment3 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | sale10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
@mytag
Scenario: See list the propertyname , the avatar , owner , content , price of property  
	Given I open details of 'PIS Top Apartment1'
	Then The property details have be show
	| PropertyName       | Avatar                  | Images    | Property Type | Content                                                                                | Street         | Ward        | District | Price | UnitPrice | Area  | BedRoom | BathRoom | ParkingPlace | Owner            | Created_at | Created_post | Status   | Note | Updated_at |
	| PIS Top Apartment1 | PIS_6656-Edit-stamp.jpg | test.jpg, | Apartment     | The surrounding neighborhood is very much localized with a great number of local shops | Điền Viên Thôn | TT Tây Đằng | Ba Vì    | 10000 | USD       | 120m2 | 3       | 3        | 1            | sale10@ppc.com   | 2017-11-09 | 2017-11-09   | Đã duyệt | Done | 2017-11-09 |
