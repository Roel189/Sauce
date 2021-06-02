using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Pages
{
    public class CheckOutPage
    {
        
        public CheckOutPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebDriver WebDriver { get; }
        private IWebElement checkOutBtn => WebDriver.FindElement(By.XPath("//*[@id='checkout']"));
        private IWebElement firstNameField => WebDriver.FindElement(By.XPath("//*[@id='first-name']"));
        private IWebElement lastNameField => WebDriver.FindElement(By.XPath("//*[@id='last-name']"));
        private IWebElement zipCodeField => WebDriver.FindElement(By.XPath("//*[@id='postal-code']"));
        private IWebElement continueBtn => WebDriver.FindElement(By.XPath("//*[@id='continue']"));
        private IWebElement finishBtn => WebDriver.FindElement(By.XPath("//*[@id='finish']"));
        private IWebElement checkOutCompleteMsg => WebDriver.FindElement(By.XPath("//*[@id='header_container']/div[2]/span"));
        private IWebElement thanksOrderMsg => WebDriver.FindElement(By.XPath("//*[@id='checkout_complete_container']/h2"));

        public void FillCheckOutFields(Table data)
        {
            var DataRow = data.Rows[0];

            firstNameField.SendKeys(DataRow["First Name"]);
            lastNameField.SendKeys(DataRow["Last Name"]);
            zipCodeField.SendKeys(DataRow["Zip Code"]);
            ClickContinueButton();
        }
        public void ClickCheckoutButton()
        {
            checkOutBtn.Click();
        }
        public void ClickContinueButton()
        {
            continueBtn.Click();
        }
        public void ClickFinishButton()
        {
            finishBtn.Click();
        }
        public string CheckOutCompleteMessage()
        {
            return checkOutCompleteMsg.Text;

        }
        public string CheckOutThanksOrderMessage()
        {
            return thanksOrderMsg.Text;
        }
    }
}
