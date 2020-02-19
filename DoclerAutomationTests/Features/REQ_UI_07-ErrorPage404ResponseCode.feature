@REQ-UI-07
@High
Feature: REQ_UI_07-ErrorPage404ResponseCode
	In order to get correct API responses
	As a system
	I want to send 404 HTTP Response Code when user tries to open some invalid/error page

@404HTTPResponseCodeOnErrorPage
Scenario: Verify 404 HTTP Response Code On Error Page
  Given I have opened the tested webpage
  When I click error menu
  Then I should get "404" HTTP response code
