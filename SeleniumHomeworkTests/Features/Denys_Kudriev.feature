Feature: Denys_Kudriev
	Homework for Cucumber/Gherkin 

Background:
	Given I am an Internet user navigating the https://www.epam.com/ website

@scenario1
Scenario Outline: Look for job
	Given I go to the job listing page
	When I enter into the keyword input bar '<Value>'
	And I click on the Find button
	Then I see the vacancies for this profession

	Examples:
		| Value                     |
		| Software Testing Engineer |
		| Software Developer        |

@scenario2
Scenario: Check services highlighting
	Given I go to the services page
	When I highlight consult
	Then I can see the text within

@scenario3
Scenario: Check searchbar with spaces
	Given I go to the main page
	When I enter spaces in the searchbar
	Then no search is done

@scenario4
Scenario: Check filter on our work page
	Given I navigate to our work page
	When I select industries and content types filters
	Then I can see selected filter items

@scenario5
Scenario: Check email validation on contact us page
	Given I navigate to contact us page
	When I enter some shitty value in the email field
	Then I see email validation error

@scenario6
Scenario: Check phone validation on contact us page
	Given I navigate to contact us page
	When I enter some shitty value in the phone field
	Then I see phone validation error

@scenario7
Scenario: Check required fields on contact us page
	Given I navigate to contact us page
	When I enter nothing in the required fields
	Then I see field required errors

@scenario8
Scenario: Check FAQ collapsable paragraph on FAQ page
	Given I navigate to the FAQ page
	When I click on the expandable plus icons
	Then I see the content hidden within