@REQ-UI-06
@Low
Feature: REQ_UI_06-FormButtonActiveStatus
	In order to display active buttons properly on the page
	As a system
	I want FormButton to be active after user click on it

@FormButtonActiveStatus
Scenario:  Verify FormButton Active Status After User Click On It
  Given I have opened the tested webpage
  When I click form menu
  Then It should turn to active status
