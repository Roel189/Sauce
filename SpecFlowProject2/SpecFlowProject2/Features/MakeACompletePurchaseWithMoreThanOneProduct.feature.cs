﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.8.0.0
//      SpecFlow Generator Version:3.8.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowProject2.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MakeACompletePurchaseWithMoreThanOneProduct")]
    public partial class MakeACompletePurchaseWithMoreThanOneProductFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "MakeACompletePurchaseWithMoreThanOneProduct.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "MakeACompletePurchaseWithMoreThanOneProduct", "\tSimple calculator for adding two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("MakeACompletePurchaseWithMoreThanOneProduct")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "secret_sauce", "YES", "YES", "NO", "NO", "YES", "NO", "Ana", "Silva", "11010-123", "CHECKOUT: COMPLETE!", "THANK YOU FOR YOUR ORDER", null)]
        public virtual void MakeACompletePurchaseWithMoreThanOneProduct(string username, string password, string t_Shirt, string backpack, string bikeLight, string jacket, string onesie, string t_ShirtRed, string firstName, string lastName, string zipCode, string checkoutCompleteMessage, string thanksMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Username", username);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("T-Shirt", t_Shirt);
            argumentsOfScenario.Add("Backpack", backpack);
            argumentsOfScenario.Add("Bike Light", bikeLight);
            argumentsOfScenario.Add("Jacket", jacket);
            argumentsOfScenario.Add("Onesie", onesie);
            argumentsOfScenario.Add("T-Shirt(Red)", t_ShirtRed);
            argumentsOfScenario.Add("First Name", firstName);
            argumentsOfScenario.Add("Last Name", lastName);
            argumentsOfScenario.Add("Zip Code", zipCode);
            argumentsOfScenario.Add("Checkout Complete Message", checkoutCompleteMessage);
            argumentsOfScenario.Add("Thanks Message", thanksMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MakeACompletePurchaseWithMoreThanOneProduct", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
testRunner.Given("The user acess the saucedemo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table4.AddRow(new string[] {
                            string.Format("{0}", username),
                            string.Format("{0}", password)});
#line 7
    testRunner.When("the user fills the mandatory fields", ((string)(null)), table4, "When ");
#line hidden
#line 10
 testRunner.And("The user clicks to confirm the login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "T-Shirt",
                            "Backpack",
                            "Bike Light",
                            "Jacket",
                            "Onesie",
                            "T-Shirt(Red)"});
                table5.AddRow(new string[] {
                            string.Format("{0}", t_Shirt),
                            string.Format("{0}", backpack),
                            string.Format("{0}", bikeLight),
                            string.Format("{0}", jacket),
                            string.Format("{0}", onesie),
                            string.Format("{0}", t_ShirtRed)});
#line 11
 testRunner.And("The user selects more than one products in the chart", ((string)(null)), table5, "And ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "First Name",
                            "Last Name",
                            "Zip Code"});
                table6.AddRow(new string[] {
                            string.Format("{0}", firstName),
                            string.Format("{0}", lastName),
                            string.Format("{0}", zipCode)});
#line 14
 testRunner.And("The user makes the checkout", ((string)(null)), table6, "And ");
#line hidden
#line 17
 testRunner.Then(string.Format("The user finishes the purcharse with the messages\'{0}\' and \'{1}\'", checkoutCompleteMessage, thanksMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
