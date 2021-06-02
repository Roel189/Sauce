using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Drivers
{
    public class SeleniumWebDriver
    {

        private IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public SeleniumWebDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver Setup()
        {
            var chromeOptions = new ChromeOptions();
            //driver = ChromeDriver(@"C:\Driver\");
            driver = new ChromeDriver(@"\..\Driver\");//C:\Users\QAT\source\repos\SpecFlowProject2\SpecFlowProject2\Driver
            _scenarioContext.Set(driver, "WebDriver");
            driver.Manage().Window.Maximize();

            return driver;
        }
        
       
    }
}
