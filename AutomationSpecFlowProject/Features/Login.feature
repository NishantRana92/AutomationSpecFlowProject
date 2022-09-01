﻿Feature: Login
To cover test scenarios on Login feature 



Scenario: Loging successfully into the application
	Given User Navigate to application
	And clicking on sign In button
	And Enter user logindetails as following :
			| UserName |   Password |
			| test_09@test.com |  Test.99 |
	When Click on Sign in button
	Then Verify The Welcome message


Scenario: Loging into the application with invalid email
	Given User Navigate to application
	And clicking on sign In button
	And Enter user logindetails as following :
			| UserName |   Password |
			| test.test.com |  Test |
	When Click on Sign in button
	Then Verify The error message
			| message            |
			| There is 1 error Invalid email address.        |

Scenario: Loging into the application with invalid password
	Given User Navigate to application
	And clicking on sign In button
	And Enter user logindetails as following :
			| UserName |   Password |
			| test_09@test.com |  Test |
	When Click on Sign in button
	Then Verify The error message
			| message |
			| There is 1 error Invalid password.        |

Scenario: Loging into the application with empty email and password
	Given User Navigate to application
	And clicking on sign In button
	And Enter user logindetails as following :
			| UserName |   Password |
			|  |   |
	When Click on Sign in button
	Then Verify The error message
	| message |
	| There is 1 error An email address required.       |