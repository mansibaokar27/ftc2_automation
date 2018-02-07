Feature: AddProject
	
Scenario: Adding new project by admin
When I perfom log in operation as admin
| Field     | Value                |
| User Name | ftcadmin@yopmail.com |
| Password  | 1234                 |
Then I successfully logged in as admin and navigated to admin dashboard
When I click on Manage Projects tab
Then I navigate to Manage Projects page
When I click on Add Project button
Then I navigate to Create project page
When I enter create project details
And  I click on save button for project creation
Then I should be able to create the project




