Feature: MakeACompletePurchaseWithMoreThanOneProduct
	Simple calculator for adding two numbers

@mytag
Scenario: MakeACompletePurchaseWithMoreThanOneProduct
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
	Then The user finishes the purcharse with the messages'<Checkout Complete Message>' and '<Thanks Message >'

	Examples:
	| Username      | Password     | T-Shirt | Backpack | Bike Light | Jacket | Onesie | T-Shirt(Red) | First Name | Last Name | Zip Code  | Checkout Complete Message | Thanks Message           |
	| standard_user | secret_sauce | YES     | YES      | NO         | NO     | YES    | NO           | Ana        | Silva     | 11010-123 | CHECKOUT: COMPLETE!       | THANK YOU FOR YOUR ORDER |

