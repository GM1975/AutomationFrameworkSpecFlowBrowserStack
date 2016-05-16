using GMAutomation;
using GMAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GMTests.Steps
{
    [Binding]
    public sealed class WordPress
    {
        

        [Given(@"a browser opened at WordPress login page")]
        public void GivenABrowserOpenedAtWordPressLoginPage()
        {
            LoginPage.GoTo();
        }

        [When(@"WordPress is logged in as '(.*)' with password '(.*)'")]
        public void WhenWordPressIsLoggedInAsWithPassword(string userName, string password)
        {
            LoginPage.LoginAs(userName, password);
        }

        [When(@"I click the button My Site")]
        public void WhenIClickTheButtonMySite()
        {
            TopBarPage.ClickMySite();
        }


        [Then(@"The WordPress homepage is displayed")]
        public void ThenTheWordPressHomepageIsDisplayed()
        {
            Assert.IsTrue(ReaderPage.IsAt());
        }

        [When(@"I click the button Blog Posts Add")]
        public void WhenICickTheButtonBlogPostsAdd()
        {
            SideBarPage.CickTheButtonBlogPostsAdd();
        }

        [Then(@"the new post editor is displayed")]
        public void ThenTheNewPostEditorIsDisplayed()
        {
            NewPostPage.PostEditorDisplayed();
        }



    }
}
