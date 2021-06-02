using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;
using SpecFlowProject2.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
   
        [Binding]
        public class SauceDemoSteps
        {
            private readonly ScenarioContext _scenarioContext;
            private LoginPage loginPage = null;
            private String usernameField;
            private String passwordField;
            private InventoryPage inventory = null;
            private CheckOutPage checkoutPage = null;
            IWebDriver webDriver;
            public SauceDemoSteps(ScenarioContext scenarioContext)
            {
                this._scenarioContext = scenarioContext;
            }
            

            [Given(@"The user acess the saucedemo")]
            public void a()
            {
                webDriver = _scenarioContext.Get<SeleniumWebDriver>("SeleniumWebDriver").Setup();
                webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
                loginPage = new LoginPage(webDriver);
                checkoutPage = new CheckOutPage(webDriver);
                inventory = new InventoryPage(webDriver);
        }

            [When(@"the user fills the mandatory fields")]
            public void WhenTheUserFillsTheMandatoryFields(Table CustomerUserTable)
            {
                // Get the table row object for Active Status
                var CustomerUserRow = CustomerUserTable.Rows[0];

                // Save new values
                usernameField = CustomerUserRow["Username"];
                passwordField = CustomerUserRow["Password"];

                loginPage.Login(usernameField, passwordField);
            }

            [When(@"The user clicks to confirm the login")]
            public void WhenTheTheUserClicksToConfirmTheLogin()
            {

                loginPage.ClickOnLoginButton();
            }

            [Then(@"The user receives the message '(.*)'")]
            public void ThenTheTheUserReceivesTheMessage(String ExpectedMessage)
            {
                Assert.AreEqual(ExpectedMessage, loginPage.MsgLock());
            }
        [When(@"The user selects more than one products in the chart")]
        public void WhenTheTheUserSelectsMoreThanOneProductsInTheChart(Table products)
        {
            inventory = new InventoryPage(webDriver);
            checkoutPage = new CheckOutPage(webDriver);

            inventory.AddToChart(products);
            inventory.ClickChart();
            checkoutPage.ClickCheckoutButton();
        }
        [When(@"The user makes the checkout")]
        public void WhenTheTheUserMakesTheCheckout(Table data)
        {
            checkoutPage.FillCheckOutFields(data);
        }

        [Then(@"The user finishes the purcharse with the messages'(.*)' and '(.*)'")]
        public void TheUserFinishesThePurcharse(String ExpectedMessage1, String ExpectedMessage2)
        {
            checkoutPage.ClickFinishButton();

            Assert.AreEqual(ExpectedMessage1, checkoutPage.CheckOutCompleteMessage());
            Assert.AreEqual(ExpectedMessage2, checkoutPage.CheckOutThanksOrderMessage());

        }

        [Then(@"The system shows the Item total: '(.*)', The Tax '(.*)' and the Final Total '(.*)'")]
        public void ThenTheSystemShowsTheItemTotal(String ItemTotal, String Tax,String FinTotal)
        {
            
            Assert.AreEqual(ItemTotal, inventory.ReturnValue());
            Assert.AreEqual(Tax, inventory.ReturnTax());
            Assert.AreEqual(FinTotal, inventory.ReturnFinValue());

        }
    }

}