Feature: RomanNumeralKata

A short summary of the feature

Scenario: Simple One Roman Char Check
	Given the roman string is "L"
	When I request of the conversion of char(s) into a Number
	Then the result of conversion to Number will be 50

Scenario: Two-digit Roman Char Plus Sum Check
	Given the roman string is "ML"
	When I request of the conversion of char(s) into a Number
	Then the result of conversion to Number will be 1050

Scenario: Two-digit Roman Char Minus Sum Check
	Given the roman string is "LM"
	When I request of the conversion of char(s) into a Number
	Then the result of conversion to Number will be 950

Scenario: Invalid Roman Char Check
	Given the roman string is "T"
	When I request of the conversion of char(s) into a Number
	Then it throws exception