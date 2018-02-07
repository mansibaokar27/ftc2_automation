Feature: TalentOnBoarding

Scenario: Editing talent on bording
When I perform Login operation as talent
| Field     | Value            |
| User Name | alia@yopmail.com |
| Password  | 1234             |
Then I successfully logged in as talent
When I click on Edit profile button
Then I successfully navigate to personal details page
When I edit personal details tab
And  I click on next button
Then I successfully navigate to Talent page
When I edit Talent page
And  I click on next button
Then I successfully navigate to Interest page
When I edit Interest page
And  I click on next button
Then I successfully navigate to skills page
When I edit skill page
And  I click on next button
Then I successfully navigate to Attributes page
When I edit Attributes page
And  I click on next button
Then I successfully navigate to Media page
When I edit media page
And  I click on next button
Then I successfully navigate to Experience page 
When I edit Experience page
And  I click on next button
Then I successfully navigate to Education page
When I edit Education page
And  I click on next button
Then I succesfully navigate to Additional page
When I edit Additional page
And  I click on next button
Then I successfully navigate to profile completion page
When I click on view dashboard button
Then I successfully navigate to talent dashboard
