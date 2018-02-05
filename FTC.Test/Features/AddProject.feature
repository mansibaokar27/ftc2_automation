Feature: AddProject
	
Scenario: Adding new project by admin
When I perfom log in operation
| Field     | Value             |
| User Name | ftc@fthecouch.com |
| Password  | 1234              |
Then I successfully logged in
When I navigate to admin dashboard
When I click on Manage Projects tab
Then I navigate to Manage Projects page
When I click on Add Project button
Then I navigate to Manage project page
When I enter create project details
And  I click on save button
Then I should be able to create the project



