Feature: ProjectPageTest

A short summary of the feature

@tag1
Scenario: all elements should be display in Project page 
	Given click projects module
	And click on Add project button
	When Project name text box should display
	And  Project manager 
	And  tean size text box should display
	And status drop down should display 
	Then submit button should display 

