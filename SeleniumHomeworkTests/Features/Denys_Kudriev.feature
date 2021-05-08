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
Scenario Outline: Check length validation on contact us page
	Given I navigate to contact us page
	When I enter value with the length of '<Length>' in the '<Field>' field
	Then I can see under the '<Field>' field '<Error Message>' error message

	Examples:
		| Field      |
		| First Name |
		| Last Name  |

@scenario5
Scenario Outline: Check email validation on contact us page
	Given I navigate to contact us page
	When I enter '<Value>' in the 'Email' field
	Then I can see under the 'Email' field 'Incorrect email format' error message

	Examples:
		| Value      |
		| First Name |
		| Last Name  |

@scenario6
Scenario Outline: Check phone validation on contact us page
	Given I navigate to contact us page
	When I enter '<Value>' in the 'Phone' field
	Then I can see under the 'Phone' field 'Only digits, space, plus, and semicolon are allowed. Maximum number of characters is 50.' error message

	Examples:
		| Value  |
		| pfasdf |
		| grdl   |

@scenario7
Scenario Outline: Check required fields on contact us page
	Given I navigate to contact us page
	When I enter '' in the '<Field>' field
	Then I can see under the '<Field>' field 'This is a required field' error message

	Examples:
		| Field      |
		| First Name |
		| Last Name  |
		| Email      |
		| Phone      |

@scenario8
Scenario: Check FAQ collapsable paragraph on FAQ page
	Given I navigate to the FAQ page
	When I click on the expandable plus icons
	Then I see the content hidden within