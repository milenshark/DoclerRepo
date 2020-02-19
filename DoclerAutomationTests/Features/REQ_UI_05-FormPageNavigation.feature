@REQ-UI-05
@High
Feature: REQ_UI_05-FormPageNavigation
	In order to get quickly to FormPage
	As a user
	I want to be on FormPage when I click on Form button

@FormPageNavigation
Scenario: Verify FormPage Is Displayed Properly
  Given I have opened the tested webpage
  When I click form menu
  Then I should get navigated to the form page
