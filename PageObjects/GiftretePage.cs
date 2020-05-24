using CommunityProject2020.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CommunityProject2020.PageObjects
{
    class GiftretePage
    {
        IWebDriver driver;
       

        IWebElement TheFirstSignIn => driver.FindElement(By.CssSelector(" a.sb-btn2"));
        IWebElement email => driver.FindElement(By.CssSelector("#user_email"));
        IWebElement Password => driver.FindElement(By.Id("user_password"));
        IWebElement TheSecondSignIn => driver.FindElement(By.Id("btn_signin"));
        IWebElement Community => driver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/div[2]/div/div[2]/nav/ul/li[2]/a/span"));
        IWebElement Create => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/ul/a[1]"));
        IWebElement CommunityName => driver.FindElement(By.Id("name"));
        IWebElement CommunityType => driver.FindElement(By.CssSelector(".mb--100 > div > div > div > div > form > div.switch-field > label:nth-child(2)"));
        IWebElement CommunityHandle => driver.FindElement(By.Id("cleanname"));
        IWebElement CommunityDescription => driver.FindElement(By.CssSelector("html"));
        IWebElement CommunityCategory => driver.FindElement(By.Id("group_type_id"));
        IWebElement Location => driver.FindElement(By.Id("autocomplete"));
        IWebElement Website => driver.FindElement(By.Id("website"));
        IWebElement Image => driver.FindElement(By.XPath("//*[@id='files']"));
        IWebElement CreateComm => driver.FindElement(By.XPath("//*[@id='btn_create']"));

        
        public void ClickCreateCommunityButton()
        {
            Community.Click();
        }
        public void UploadImage()
        {
            Image.SendKeys("C:\\Users\\44757\\Documents\\CommunityProject2020\\CommunityProject2020\\TestData\\Textfile\\596517_ICBA0_8576_002_100_0000_Light.jpg");
        }
        public void EnterCommunityWebsite()
        {
            Website.SendKeys("www.telegram.com");
        }
        public void EnterLocation()
        {
            Location.SendKeys("London");
        }
        public void SelectCorporationFromCommunityCategory()
        {
            SelectElement Select = new SelectElement(CommunityCategory);
            Select.SelectByValue("2");
        }
        public void EnterCommunityDescription()
        {
            CommunityDescription.SendKeys("Dream Big ");
        }
        public void EnterCommunityHandle()
        {
            CommunityHandle.SendKeys("Vision2020");
        }
        public void ClickCommunityType()
        {
            CommunityType.Click();
        }
        public void EnterCommunityName()
        {
            CommunityName.SendKeys("GetItRight");
        }
        public void ClickCreate()
        {
           Create.Click();
            
        }
        public void ClickCommunity()
        {
            Community.Click();
        }
        public void clickSign()
        {
           TheSecondSignIn.Click();
        }

        public void EnterPassword()
        {
            Password.SendKeys("Ademide1");
        }
        public void EnterEmail()
        {
            email.SendKeys("laykay2008@yahoo.com");
        }
        public void ClickSignIn()
        {
            TheFirstSignIn.Click();
            
        }
        
        public GiftretePage()
        {
            driver = Hook.driver;
           
        }
        public void NavigateToSite() 
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/");
        }
    }
}
