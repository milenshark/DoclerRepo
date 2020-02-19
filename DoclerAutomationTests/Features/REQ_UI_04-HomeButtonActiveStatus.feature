@REQ-UI-04
@Low
Feature: REQ_UI_04-HomeButtonActiveStatus
	In order to display active buttons properly on the page
	As a system
	I want HomeButton to be active after user click on it

@HomeButtonActiveStatus
Scenario: Verify HomeButton Active Status After User Click On It
  Given I have opened the tested webpage
  When I click home menu
  Then It should turn to active status
