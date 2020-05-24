using CommunityProject2020.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityProject2020.PageObjects
{
    class DiscussionPage
    {
        IWebDriver driver;
        IWebElement SignInIcon => driver.FindElement(By.CssSelector(" a.sb-btn2"));
        IWebElement Email => driver.FindElement(By.Id("user_email"));
        IWebElement Password => driver.FindElement(By.Id("user_password"));
        IWebElement SignInButton => driver.FindElement(By.Id("btn_signin"));
        IWebElement Community => driver.FindElement(By.XPath("(//span[@class='mm-text'])[2]"));
        IWebElement Communities => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/ul/a[2]"));
        IWebElement CommunityIBelong => driver.FindElement(By.XPath("//*[@id='2570']/div[2]/p"));
        IWebElement Discussion => driver.FindElement(By.XPath("//*[@id='content']/div[1]/div/div/div/div/div[1]/ul/a[6]"));
        IWebElement CreateDiscussion => driver.FindElement(By.CssSelector("#toggle-create-post > a"));
        IWebElement Name => driver.FindElement(By.Id("subject"));
        IWebElement Description => driver.FindElement(By.Id("description"));
        IWebElement DiscussionImage => driver.FindElement(By.XPath("//*[@id='files']"));
        IWebElement Publish => driver.FindElement(By.Id("btn_create"));
        public void ClickPublish()
        {
            Publish.Click();
        }
        public void UploadDiscussionImage()
        {
            DiscussionImage.SendKeys("C:\\Users\\44757\\Documents\\CommunityProject2020\\CommunityProject2020\\TestData\\Textfile1\\596518_I18V0_8508_002_100_0000_Light.jpg");

        }
        public void EnterDescription()
        {
            Description.SendKeys("Life is beautiful");
        }
        public void TitleName()
        {
            Name.SendKeys("Be Optimistic");
        }
        public void ClickCreateDiscussion()
        {
            CreateDiscussion.Click();
        }
        public void ClickDiscussion()
        {
            Discussion.Click();
        }
        public void ClickCommunityIBelong()
        {
            CommunityIBelong.Click();
        }
        public void ClickCommunities()
        {
            Communities.Click();
        }
        public void ClickCommunity()
        {
            Community.Click();
        }
        public void ClickSignInButton()
        {
            SignInButton.Click();
        }
        public void EnterPassword()
        {
            Password.SendKeys("Ademide1");
        }
        public void EnterEmail()
        {
            Email.SendKeys("laykay2008@yahoo.com");
        }
        
        public void ClickSignInIcon()
        {
            SignInIcon.Click();
        }
        public DiscussionPage()
        {
            driver = Hook.driver;
        }
        public void NavigateToSite()
        {
            driver.Navigate().GoToUrl("http://www.qa.giftrete.com");
        }

        
    }

}
