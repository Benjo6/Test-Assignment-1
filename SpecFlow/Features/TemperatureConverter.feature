Feature: TemperatureConverter

A short summary of the feature

Scenario: Fahrenheit to Celsius
 Given the temperature value is 35 degrees Fahrenheit
 When I request the conversion of this temperature into Celsius
 Then the result of conversion to Celsius will be 1.67 degrees

Scenario: Fahrenheit to Kelvin
 Given the temperature value is 35 degrees Fahrenheit
 When I request the conversion of this temperature into Kelvin
 Then the result of conversion to Kelvin will be 274.82 degrees

Scenario: Fahrenheit to Celsius Exception
 Given the temperature value is -465 degrees Fahrenheit
 When I request the conversion of this temperature into Celsius
 Then it will throw an exception

Scenario: Fahrenheit to Kelvin Exception
 Given the temperature value is -465 degrees Fahrenheit
 When I request the conversion of this temperature into Kelvin
 Then it will throw an exception

Scenario: Celsius to Fahrenheit
 Given the temperature value is 29 degrees Celsius
 When I request the conversion of this temperature into Fahrenheit
 Then the result of conversion to Fahrenheit will be 84.2 degrees

Scenario: Celsius to Kelvin
 Given the temperature value is 29 degrees Celsius
 When I request the conversion of this temperature into Kelvin
 Then the result of conversion to Kelvin will be 302.15 degrees

Scenario: Celsius to Fahrenheit Exception
 Given the temperature value is -274 degrees Celsius
 When I request the conversion of this temperature into Fahrenheit
 Then it will throw an exception

Scenario: Celsius to Kelvin Exception
 Given the temperature value is -274 degrees Celsius
 When I request the conversion of this temperature into Kelvin
 Then it will throw an exception
 

Scenario: Kelvin to Fahrenheit
 Given the temperature value is 150 degrees Kelvin
 When I request the conversion of this temperature into Fahrenheit
 Then the result of conversion to Fahrenheit will be -189.67 degrees

Scenario: Kelvin to Celsius
 Given the temperature value is 150 degrees Kelvin
 When I request the conversion of this temperature into Celsius
 Then the result of conversion to Celsius will be -123.15 degrees

Scenario: Kelvin to Fahrenheit Exception
 Given the temperature value is -1 degrees Kelvin
 When I request the conversion of this temperature into Fahrenheit
 Then it will throw an exception

Scenario: Kelvin to Celsius Exception
 Given the temperature value is -1 degrees Kelvin
 When I request the conversion of this temperature into Celsius
 Then it will throw an exception
