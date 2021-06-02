Feature: TryToLoginWithALockedUser

 Scenario: TryToLoginWithALockedUser
Given The user acess the saucedemo
    When the user fills the mandatory fields
	| Username  | Password |
	|<Username> |<Password>|
	And The user clicks to confirm the login
	Then The user receives the message '<Message>'
	Examples:
	|    Username    |     Password    |         Message                                     |
	| locked_out_user| secret_sauce    | Epic sadface: Sorry, this user has been locked out. |

