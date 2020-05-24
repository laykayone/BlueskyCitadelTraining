using CommunityProject2020.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityProject2020.PageObjects
{
    class RegistrationPage
    {
        IWebDriver driver;
        IWebElement CreateAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));
        IWebElement Firstname => driver.FindElement(By.Id("first_name"));
        IWebElement Lastname => driver.FindElement(By.Id("last_name"));
        IWebElement Email => driver.FindElement(By.Id("email"));
        IWebElement MobileNumber => driver.FindElement(By.Id("mobile"));
        IWebElement Password => driver.FindElement(By.Id("password"));
        IWebElement ConfirmPassword => driver.FindElement(By.Id("confirm_password"));
        IWebElement Register => driver.FindElement(By.Id("btn_register"));
        public void ClickRegister()
        {
            Register.Click();
        }
        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("Dammy");
        }
        public void EnterPassword()
        {
            Password.SendKeys("Dammy");
        }
        public void EnterMobileNumber()
        {
            MobileNumber.SendKeys("07578422296");
        }
        public void EnterEmail()
        {
            Email.SendKeys("laykay0ne@gmail.com");
        }
        public void EnterLastName()
        {
            Lastname.SendKeys("Johnson");
        }
        public void EnterFirstName()
        {
            Firstname.SendKeys("Ade");
        }
        public void ClickCreateAccount()
        {
            CreateAccount.Click();
        }
        public RegistrationPage()
        {
            driver = Hook.driver;
        }
        public void NavigateToPage()
        {
            driver.Navigate().GoToUrl("http://qa.giftrete.com");
        }
    }
}
