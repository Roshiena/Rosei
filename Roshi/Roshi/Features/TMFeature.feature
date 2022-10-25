Feature: TMFeature

As a TurnUp Admin
I would like to create, edit and delete Time and Management record
So that I can manage employee's time and management record


Scenario: [Create Time and Management Record]
	Given [I logged into TurnUp Portal successfully]
	When [I navigate to Time and Material Page]
	And [Create a new time and management record]
	Then [A new record is created successfully]

	Scenario Outline: [Edit Time and Management Record]
	Given [I logged into TurnUp Portal successfully]
	When [I navigate to Time and Material Page]
	And I update '<Description>' on an existing time and management record
	Then The record should have the updated '<Description>'

	Examples: 
	| Description  |
	| Time         |
	| Material     |
	| EditedRecord |
