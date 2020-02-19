@REQ-UI-03
@High
Feature: REQ_UI_03-HomePageNavigation
	In order to get quickly to HomePage
	As a user
	I want to be on HomePage when I click on Home button

@HomePageNavigation
Scenario: Verify HomePage Is Displayed Properly
  Given I have opened the tested webpage
  When I click home menu
  Then I should get navigated to the home page
