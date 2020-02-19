@REQ-UI-12
@High
Feature: REQ_UI_12-HelloPageProperText
	In order to be properly recognized
	As a user
	I want to see my name on HelloPage

@ProperDataOnHelloPage
Scenario Outline: Verify Proper Name On Hello Page 
  Given I have opened the tested webpage
	And I click form menu
  When I type <value> the input field 
	And I submit the form
  Then I should get navigated to the hello page
	And I see following text <result>
  
  Examples:
  | value   | result         |
  | John    | Hello John!    |
  | Sophia  | Hello Sophia!  |
  | Charlie | Hello Charlie! |
  | Emily   | Hello Emily!   |
