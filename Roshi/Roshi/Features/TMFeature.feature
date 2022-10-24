Feature: TMFeature

As a TurnUp Admin
I would like to create, edit and delete Time and Management record
So that I can manage employee's time and management record

@tag1
Scenario: [Create Time and Management Record]
	Given [I logged into TurnUp Portal successfully]
	When [I navigate to Time and Material Page]
	And [Create a new time and management record]
	Then [A new record is created successfully]
