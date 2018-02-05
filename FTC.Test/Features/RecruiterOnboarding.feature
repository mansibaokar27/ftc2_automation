
Feature: Recruiter onboarding			

Scenario: Editing recruiter on bording 
When I perfom log in operation
| Field     | Value              |
| User Name | Marvel@yopmail.com |
| Password  | 1234               |
Then I successfully logged in
When I navigate to my profile
Then I successfully navigate to profile page
When I edit my profile tab 
And  I click on next button
Then I successfully navigate to Work experinece tab
When I Add Work experience 
And  I click on next button
Then I successfully navigate to Awards and Recognitions tab
When I Add Awards and Recognitions 
| Field              | Value      |
| Award Title        | John Galt  |
| Award For          | 2/2/1902   |
| Award Year         | 72         |
Then I successfully navigate to Social links tab
When I Add Social links
| Field        | Value             |
| Facbook      | www.facebook.com  |
| Twitter      | www.twitter.com   |
| Instagram    | www.instagram.com |
| Youtube      | www.youtube.com   |
| Website link | www.ftc.com       |
And  I click on next button
Then I successfully navigate to Associations tab
When I Add Associations
| Field           | Value  |
| Assosication ID | 125634 |
And  I click on next button
Then I successfully navigate to Security Questions  tab
When I Add  Security Questions
| Field                           | Value    |
| Your childhood nicknam          | Chintu   |
| Your favourite childhood friend | Rohit    |
| Your favourite team             | India    |
And  I click on next button
Then I successfully navigate to dashboard