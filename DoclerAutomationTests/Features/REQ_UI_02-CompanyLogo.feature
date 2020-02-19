@REQ-UI-02
@Moderate
Feature: REQ_UI_02-CompanyLogo
	In order to improve company branding and advertising
	As a system
	I want to show the company logo on every webpage

@CompanyLogoOnHomePage
Scenario: Verify Company Logo on HomePage
  Given I have opened the tested webpage
  When I click home menu
  Then The company logo should be visible

@CompanyLogoOnFormPage
Scenario: Verify Company Logo on FormPage
  Given I have opened the tested webpage
  When I click form menu
  Then The company logo should be visible

@CompanyLogoOnErrorPage
Scenario: Verify Company Logo on ErrorPage
  Given I have opened the tested webpage
  When I open the Error page
  Then The company logo should be visible

@CompanyLogoOnHelloPage
 Scenario: Verify Company Logo on HelloPage
  Given I have opened the tested webpage
  When I open the Hello page
  Then The company logo should be visible