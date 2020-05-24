using CommunityProject2020.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace CommunityProject2020.StepDefinitions
{
    [Binding]
    public class DiscussionStep
    {
        DiscussionPage discussionPage;
        public DiscussionStep()
        {
            discussionPage = new DiscussionPage();
        }
        [Given(@"I Navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            discussionPage.NavigateToSite();
        }
        
        [Given(@"I click sign in icon")]
        public void GivenIClickSignInIcon()
        {
            discussionPage.ClickSignInIcon();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            discussionPage.EnterEmail();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            discussionPage.EnterPassword();
        }
        
        [When(@"I click sign in button")]
        public void WhenIClickSignInButton()
        {
            discussionPage.ClickSignInButton();
        }
        
        [When(@"I click community")]
        public void WhenIClickCommunity()
        {
            discussionPage.ClickCommunity();
        }
        
        [When(@"I click my communities")]
        public void WhenIClickMyCommunities()
        {
            discussionPage.ClickCommunities();
        }
        [When(@"I  select community I belong")]
        public void WhenISelectCommunityIBelong()
        {
            discussionPage.ClickCommunityIBelong();
        }
        [When(@"I click on Discussion")]
        public void WhenIClickOnDiscussion()
        {
            discussionPage.ClickDiscussion();
        }

        [When(@"I click create discussion")]
        public void WhenIClickCreateDiscussion()
        {
            discussionPage.ClickCreateDiscussion();
        }
        [When(@"I enter title name")]
        public void WhenIEnterTitleName()
        {
            discussionPage.TitleName();
        }
        [When(@"I enter a description")]
        public void WhenIEnterADescription()
        {
            discussionPage.EnterDescription();
        }
        [When(@"I select discussion image")]
        public void WhenISelectDiscussionImage()
        {
            discussionPage.UploadDiscussionImage();
        }

        [When(@"I click on publish")]
        public void WhenIClickOnPublish()
        {
            discussionPage.ClickPublish();
        }




    }
}
