Feature: SmokeTests

Scenario: Active user can log in
	Given a browser opened at WordPress login page
	When WordPress is logged in as 'gregmawsonblog' with password 'automation123!'
	Then The WordPress homepage is displayed

	

Scenario: Add Blog Post Button opens a new form
	Given a browser opened at WordPress login page
	When WordPress is logged in as 'gregmawsonblog' with password 'automation123!'
	And I click the button My Site
	And I click the button Blog Posts Add
	Then the new post editor is displayed



