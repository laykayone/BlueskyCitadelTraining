using CommunityProject2020.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace CommunityProject2020.StepDefinitions
{
    [Binding]
    public class CommunitySteps
    {
        GiftretePage giftretePage;

        public CommunitySteps()
        {
            giftretePage = new GiftretePage();
        }

       // [When(@"I click on sign in button")]
       // public void WhenIClickOnSignInButton()

       // {
           // giftretePage.ClickSignIn();
       // }


        [Given(@"I navigate to giftrete website")]

        public void GivenINavigateToGiftreteWebsite()
        {
            giftretePage.NavigateToSite();
        }
        
        [Given(@"I click on sign in")]
        public void GivenIClickOnSignIn()
        {
           giftretePage.ClickSignIn();
        }
        
        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            giftretePage.EnterEmail();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            giftretePage.EnterPassword();
        }
        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            giftretePage.clickSign();
        }

        [When(@"I click on community")]
        public void WhenIClickOnCommunity()
        {
            giftretePage.ClickCommunity();
        }

        [When(@"I click on create")]
        public void WhenIClickOnCreate()
        {
            giftretePage.ClickCreate(); 
        }
        [When(@"I enter community name")]
        public void WhenIEnterCommunityName()
        {
            giftretePage.EnterCommunityName();
        }
        [When(@"I click community type")]
        public void WhenIClickCommunityType()
        {
            giftretePage.ClickCommunityType();
        }
        [When(@"I enter community handle")]
        public void WhenIEnterCommunityHandle()
        {
            giftretePage.EnterCommunityHandle();
        }
        [When(@"I enter community description")]
        public void WhenIEnterCommunityDescription()
        {
            giftretePage.EnterCommunityDescription();
        }
        [When(@"I select community category")]
        public void WhenISelectCommunityCategory()
        {
            giftretePage.SelectCorporationFromCommunityCategory();
        }
        [When(@"I enter location")]
        public void WhenIEnterLocation()
        {
            giftretePage.EnterLocation();
        }
        [When(@"I enter community website")]
        public void WhenIEnterCommunityWebsite()
        {
            giftretePage.EnterCommunityWebsite();
        }
        [When(@"I select community image")]
        public void WhenISelectCommunityImage()
        {
            giftretePage.UploadImage();
        }

        [Then(@"I click create community button")]
        public void ThenIClickCreateCommunityButton()
        {
            giftretePage.ClickCreateCommunityButton();
        }

       



    }
}

