using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject2.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver WebDriver;
        private const string PageUri = @"https://saucedemo.com/";

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;

        }




        public static LoginPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageUri);

            return new LoginPage(driver);
        }
        private IWebElement usernameField => WebDriver.FindElement(By.XPath("//*[@id='user-name']"));
        private IWebElement passwordField => WebDriver.FindElement(By.XPath("//*[@id='password']"));
        private IWebElement loginBtn => WebDriver.FindElement(By.XPath("//*[@id='login-button']"));
        private IWebElement locked_message => WebDriver.FindElement(By.XPath("//*[@id='login_button_container']/div/form/div[3]/h3"));

        public string MsgLock()
        {
            return locked_message.Text;
        }

        public void FillUserNameField(String username)
        {
            usernameField.SendKeys(username);
        }

        public void FillPasswordField(String password)
        {
            passwordField.SendKeys(password);
        }

        public void ClickOnLoginButton()
        {
            loginBtn.Click();
        }
        public void Login(String username, String password)
        {
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);

        }


    }
}
