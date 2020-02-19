@REQ-UI-08
@High
Feature: REQ_UI_08-UITestingButtonNavigation
	In order to be sure that I am on the HomePage
	As a user
	I want to open HomePage when I click on UI Testing button


@VerifyHomePageAfterClickingUITestingButton
Scenario: Verify HomePage Upon Clicking on UI Testing button
  Given I have opened the tested webpage
  When I click UI Testing menu
  Then I should get navigated to the home page
