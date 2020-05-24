Feature: Registration
	In order for me to have access to giftrete website
	I need to register 
	

@mytag
Scenario: Valid Registration
	Given I navigate to Giftrete website
	When I click on create account button
	And I enter first name 
	And I enter last name
	And I enter email address
	#And I select the country
	And I enter mobile number
	And I enter Password
	And I enter confirm password
	And I select captcha
	And I click register
	Then I am registered
