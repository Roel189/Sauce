using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Pages
{
    public class InventoryPage 
    {
        public IWebDriver WebDriver { get; }

        public InventoryPage(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
        }
        private IWebElement BackpackAdd => WebDriver.FindElement(By.XPath("//*[@id='add-to-cart-sauce-labs-backpack']"));
        private IWebElement TShirtAdd => WebDriver.FindElement(By.XPath("//*[@id='add-to-cart-sauce-labs-bolt-t-shirt']"));
        private IWebElement OnesieAdd => WebDriver.FindElement(By.XPath("//*[@id='add-to-cart-sauce-labs-onesie']"));
        private IWebElement BikeLightAdd => WebDriver.FindElement(By.XPath("//*[@id='add-to-cart-sauce-labs-bike-light']"));
        private IWebElement JacketAdd => WebDriver.FindElement(By.XPath("//*[@id='add-to-cart-sauce-labs-fleece-jacket']"));
        private IWebElement RedTShirtAdd => WebDriver.FindElement(By.XPath("//*[@id='add-to-cart-test.allthethings()-t-shirt-(red)']"));
        private IWebElement checkOutBtn => WebDriver.FindElement(By.XPath("//*[@id='checkout']"));
        private IWebElement BackpackValue=> WebDriver.FindElement(By.CssSelector("//*[@id='inventory_container']/div/div[1]/div[2]/div[2]/div"));
        private IWebElement TShirtValue => WebDriver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[3]/div[2]/div[2]/div"));
        private IWebElement OnesieValue => WebDriver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[5]/div[2]/div[2]/div"));
        private IWebElement BikeLightValue => WebDriver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[2]/div[2]/div[2]/div"));
        private IWebElement JacketValue => WebDriver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[4]/div[2]/div[2]/div"));
        private IWebElement RedTShirtValue => WebDriver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[6]/div[2]/div[2]/div"));
        private IWebElement chart => WebDriver.FindElement(By.XPath("//*[@id='shopping_cart_container']/a"));




        private string backpack;
        private string tshirt;
        private string onesie;
        private string bikelight;
        private string jacket;
        private string redtshirt;
        private double value = 0.00;
     
        public void ClickCheckoutButton()
        {
            checkOutBtn.Click();
        }

        public void AddToChart(Table products)
        {
            // Get the table row object for Active Status
            var ProductRow = products.Rows[0];

            // Save new values
            backpack = ProductRow["Backpack"];
            tshirt = ProductRow["T-Shirt"];
            onesie = ProductRow["Onesie"];
            bikelight = ProductRow["Bike Light"];
            jacket = ProductRow["Jacket"];
            redtshirt = ProductRow["T-Shirt(Red)"];

            if (backpack == "YES")
            {
                BackpackAdd.Click();
                //Console.WriteLine(BackpackValue);

                //String x = BackpackValue.Text.Remove(0);
                //Console.WriteLine(x);
                //double y = Convert.ToDouble(x);
                value += 29.99;
            }
            if (tshirt == "YES")
            {
                TShirtAdd.Click();
                //ConvertToDouble(TShirtValue);
                value += 15.99;

            }
            if (onesie == "YES")
            {
                OnesieAdd.Click();
                //ConvertToDouble(OnesieValue);
                value += 7.99;


            }
            if (bikelight == "YES")
            {
                BikeLightAdd.Click();
               // ConvertToDouble(BikeLightValue);
                value += 9.99;

            }
            if (jacket == "YES")
            {
                JacketAdd.Click();
                //ConvertToDouble(JacketValue);
                value += 49.99;

            }
            if (redtshirt == "YES")
            {
                RedTShirtAdd.Click();
                //ConvertToDouble(RedTShirtValue);
                value += 15.99;

            }
        }
        public void ClickChart()
        {
            chart.Click();
        }
        public void  ConvertToDouble(IWebElement e)
        {
            var x = e.Text.Remove(0);
            double y = Convert.ToDouble(x);
            value += y;
           
        }
        public String ReturnValue()
        {
            return value.ToString();
        }
        public double Tax()
        {
             double t = 10.40;
            return t;
        }
        public String ReturnFinValue()
        {
            value += Tax();
            return value.ToString();
        }
        public String ReturnTax()
        {
            double t = Tax();
            return t.ToString();
        }
    }
}