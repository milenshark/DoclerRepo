@REQ-UI-09
@REQ-UI-10
@Low
Feature: REQ_UI_09_10-TextInHTMLTags
	In order to be sure that there is proper text set in HTML tags
	As a system
	I want correct tet to be displayed in h1 and p tags

@mytag
Scenario Outline: Verify Proper Text is Displayed in h1 and p HTML Tags
  Given I have opened the tested webpage
  When I click home menu
  Then I see <text> in <tagName> tag

  Examples: 
  | text																					| tagName |
  | Welcome to the Docler Holding QA Department												| h1      |
  | This site is dedicated to perform some exercises and demonstrate automated web testing. | p       |