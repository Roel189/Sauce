using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.IE;
using SpecFlowProject2.Drivers;


/*
Purpose of this class is to 
-Define actions to perform before and after feature/Scenario
-Define local and remote test execution, sauce lab settings and local host browser setting are defined

*/
namespace BDD_Specflow_Webdriver.Utils
{
    [Binding]
    public sealed class Hooks
    {
        /// <summary>
        ///  Purupse of this Hooks class is to 
        ///  Maintain shared objects across the feature scenarios
        ///  Declare any standard actions required to run pre and post scneario and feature
        ///  Declare and instantiate driver object which is shared across all features.
        /// </summary>



        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private readonly ScenarioContext _scenarioContext;
        public Hooks(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;



        [BeforeScenario]

        public void BeforeScenario()
        {

            SeleniumWebDriver seleniumWebDriver = new SeleniumWebDriver(_scenarioContext);
            _scenarioContext.Set(seleniumWebDriver, "SeleniumWebDriver");


        }

        [AfterScenario]
        public  void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        
        }




    }
}
