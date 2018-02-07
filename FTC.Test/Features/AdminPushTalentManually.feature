Feature: AdminPushTalentManually

Scenario: Admin Push talent manually 
When I perfom log in operation as admin
| Field     | Value                |
| User Name | ftcadmin@yopmail.com |
| Password  | 1234                 |
Then I successfully logged and naviagte to admin dashboard
When I click on Talent Directory
Then I successfully naviagte to Talent Directory page
When I enter the recruiter name as ""
And  I enter the project name as ""
And  I enter the job name as ""  
Then I click on serach icon
When I click on select button of talent
Then talent will move under selected tab
When I click on oush to job button
Then I should be able to push the talent to job
