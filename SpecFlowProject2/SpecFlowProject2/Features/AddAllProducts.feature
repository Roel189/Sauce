Feature: AddAllProducts

@mytag
Scenario: AddAllProducts
Given The user acess the saucedemo
    When the user fills the mandatory fields
	| Username  | Password |
	|<Username> |<Password>|
	And The user clicks to confirm the login
	And The user selects more than one products in the chart
	| T-Shirt   | Backpack   | Bike Light   | Jacket   | Onesie   | T-Shirt(Red)   |
	| <T-Shirt> | <Backpack> | <Bike Light> | <Jacket> | <Onesie> | <T-Shirt(Red)> |
	And The user makes the checkout
	| First Name   | Last Name   |  Zip Code  |
	| <First Name> | <Last Name> | <Zip Code> |
	Then The system shows the Item total: '<Item Total>', The Tax '<Tax>' and the Final Total '<Total>'
	Then The user finishes the purcharse with the messages'<Checkout Complete Message>' and '<Thanks Message >'

	Examples:
	| Username      | Password     | T-Shirt | Backpack | Bike Light | Jacket | Onesie | T-Shirt(Red) | First Name | Last Name | Zip Code  | Checkout Complete Message | Thanks Message           | Item Total | Tax   | Total  |
	| standard_user | secret_sauce | YES     | YES      | YES        | YES    | YES    | YES          | Ana        | Silva     | 11010-123 | CHECKOUT: COMPLETE!       | THANK YOU FOR YOUR ORDER | 129.94     | 10.4  | 140.34 |
