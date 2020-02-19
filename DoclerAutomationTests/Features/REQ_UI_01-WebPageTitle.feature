@REQ-UI-01
@Moderate
Feature: REQ_UI_01-WebPageTitle
	In order to keep better track of navigation on the tested website
	As a user
	I want to be able to see website title on each webpage

@WebPageTitleOnHomePage
Scenario: Verify WebPage Title on HomePage
  Given I have opened the tested webpage
  When I click home menu
  Then The webpage title should be "UI Testing Site"

@WebPageTitleOnFormPage
Scenario: Verify WebPage Title on FormPage
  Given I have opened the tested webpage
  When I click form menu
  Then The webpage title should be "UI Testing Site"

@WebPageTitleOnErrorPage
Scenario: Verify WebPage Title on ErrorPage
  Given I have opened the tested webpage
  When I click error menu
  Then The webpage title should be "UI Testing Site"

@WebPageTitleOnHelloPage
Scenario: Verify WebPage Title on HelloPage
  Given I have opened the tested webpage
  When I open the Hello page
  Then The webpage title should be "UI Testing Site"