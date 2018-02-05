Feature: TalentOnBoarding

Scenario: Editing talent on bording
When I perfom log in operation
| Field     | Value              |
| User Name | pari@yopmail.com |
| Password  | 1234              |	
Then I successfully logged in
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
And I click on next button
Then I successfully navigate to Attributes page
When I edit Attributes page
And I click on next button
Then I successfully navigate to Media page
When I edit media page
And I click on next button
Then I successfully navigate to Experience page 
