﻿Feature: AddContest

Scenario: Adding new contest by admin
When I perfom log in operation as admin
| Field     | Value                |
| User Name | ftcadmin@yopmail.com |
| Password  | 1234                 |
Then I successfully logged in as admin and navigated to admin dashboard
When I click on Manage Contest  tab
Then I successfully naviagte to Manage contest  page
When I click on Add Contest  button
Then I successfully navigate to create contest  page
When I enter details of  create  contest
And  I click on save  button
Then I should able to  save  contest



