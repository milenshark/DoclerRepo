@REQ-UI-11
@High
Feature: REQ_UI_11-FormPageInputBoxAndSubmitButton
	In order to enter some data
	As a user
	I want to see Input Box and Submit Button on the Form Page

@VerifyInputBoxAndSubmitButtonOnFormPage
Scenario: Verify FormPage Input Box and Submit Button
  Given I have opened the tested webpage
  When I click form menu
  Then I see 1 of input field
	And I see 1 of submit field
