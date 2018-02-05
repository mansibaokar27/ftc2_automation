Feature: BlockUser

Scenario: verify the blocked talent is unable to login 
When I perfom log in operation
| Field     | Value             |
| User Name | ftcadmin@yopmail.com |
| Password  |1234|
Then I successfully logged and naviagte to dashboard
When I click on Talent directory
Then I navigate to Talent directory page
When I click on deactive option of the talent
And  I click on "Yes" option on the confirmation pop up
Then I Logout as "admin"
When I perfom log in operation 
| Field     | Value             |
| User Name | ftcadmin@yopmail.com |
| Password  |1234|


	


