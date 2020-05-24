Feature: Discussion
	I want to view my community so that I can monitor my community for discussion

Scenario: View Discussion
	Given I Navigate to giftrete website
	And I click sign in icon
	When I enter my email 
	And I enter my password
	And I click sign in button
	And I click community
	And I click my communities
	And I  select community I belong
	And I click on Discussion
	And I click create discussion
	And I enter title name
	And I enter a description
	And I select discussion image
	And I click on publish
	#And I select community
	#And I click on image class
	#Then I should be able to view my discussion
