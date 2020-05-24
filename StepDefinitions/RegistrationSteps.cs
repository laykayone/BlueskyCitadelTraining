using CommunityProject2020.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace CommunityProject2020.StepDefinitions
{
    [Binding]
    public class RegistrationStep
    {
        RegistrationPage registrationPage;
        public RegistrationStep()
        {
            registrationPage = new RegistrationPage();
        }

        [Given(@"I navigate to Giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            registrationPage.NavigateToPage();
        }
        
        [When(@"I click on create account button")]
        public void WhenIClickOnCreateAccountButton()
        {
            registrationPage.ClickCreateAccount();
        }
        
        [When(@"I enter first name")]
        public void WhenIEnterFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            registrationPage.EnterLastName();
        }
        
        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
            registrationPage.EnterEmail();
        }
        
        [When(@"I select the country")]
        public void WhenISelectTheCountry()
        {
            
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registrationPage.EnterMobileNumber();
        }
        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }


        [When(@"I enter confirm password")]
        public void WhenIEnterConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }
        
        [When(@"I select captcha")]
        public void WhenISelectCaptcha()
        {
            
        }
        
        [When(@"I click register")]
        public void WhenIClickRegister()
        {
            registrationPage.ClickRegister();
        }
        
        [Then(@"I am registered")]
        public void ThenIAmRegistered()
        {
            
        }
    }
}
