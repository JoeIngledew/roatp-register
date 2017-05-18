﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Esfa.Roatp.Register.ApiIntegrationTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RoatpRegisterApi")]
    public partial class RoatpRegisterApiFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RoatpRegisterApi.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RoatpRegisterApi", "\tAs a user\r\n\tI would like to use roatp register api", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ukprn",
                        "Name",
                        "ProviderType",
                        "ContractedForNonLeviedEmployers",
                        "NewOrganisationWithoutFinancialTrackRecord",
                        "ParentCompanyGuarantee",
                        "StartDate",
                        "EndDate"});
            table1.AddRow(new string[] {
                        "19992101",
                        "ABC Institute",
                        "MainProvider",
                        "False",
                        "True",
                        "True",
                        "20-Mar-2017",
                        ""});
            table1.AddRow(new string[] {
                        "29992101",
                        "DEF Institute",
                        "MainProvider",
                        "False",
                        "True",
                        "True",
                        "20-Mar-2017",
                        ""});
            table1.AddRow(new string[] {
                        "39992101",
                        "GHI Institute",
                        "MainProvider",
                        "False",
                        "True",
                        "True",
                        "20-Mar-2017",
                        ""});
#line 6
testRunner.Given("the following roatp providers are available", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Roatp Register API should return all providers")]
        [NUnit.Framework.CategoryAttribute("apiintegrationtests")]
        public virtual void RoatpRegisterAPIShouldReturnAllProviders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roatp Register API should return all providers", new string[] {
                        "apiintegrationtests"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 14
testRunner.When("I request for All providers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
testRunner.Then("I should get All providers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Roatp Register API should return a provider")]
        [NUnit.Framework.CategoryAttribute("apiintegrationtests")]
        public virtual void RoatpRegisterAPIShouldReturnAProvider()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roatp Register API should return a provider", new string[] {
                        "apiintegrationtests"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 19
testRunner.When("I request for provider with Ukprn 29992101", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.Then("I should get A provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Roatp Register API should throw error when provider start date is in future")]
        [NUnit.Framework.CategoryAttribute("apiintegrationtests")]
        public virtual void RoatpRegisterAPIShouldThrowErrorWhenProviderStartDateIsInFuture()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roatp Register API should throw error when provider start date is in future", new string[] {
                        "apiintegrationtests"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 24
testRunner.Given("A Roatp provider with future start date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
testRunner.Then("I should get an exception when i request for a Provider with future start date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Roatp Register API should throw error when provider end date is in past")]
        [NUnit.Framework.CategoryAttribute("apiintegrationtests")]
        public virtual void RoatpRegisterAPIShouldThrowErrorWhenProviderEndDateIsInPast()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roatp Register API should throw error when provider end date is in past", new string[] {
                        "apiintegrationtests"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 29
testRunner.Given("A Roatp provider with past end date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
testRunner.Then("I should get an exception when i request for a Provider with past end date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Roatp Register API should acknowledge existence when provider end date is in futu" +
            "re")]
        [NUnit.Framework.CategoryAttribute("apiintegrationtests")]
        public virtual void RoatpRegisterAPIShouldAcknowledgeExistenceWhenProviderEndDateIsInFuture()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roatp Register API should acknowledge existence when provider end date is in futu" +
                    "re", new string[] {
                        "apiintegrationtests"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 34
testRunner.Given("A Roatp provider with future end date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
testRunner.Then("I should not get any exception when i request for a Provider with future end date" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Roatp Register API should throw error for provider not found")]
        [NUnit.Framework.CategoryAttribute("apiintegrationtests")]
        public virtual void RoatpRegisterAPIShouldThrowErrorForProviderNotFound()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roatp Register API should throw error for provider not found", new string[] {
                        "apiintegrationtests"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 39
testRunner.When("I request for provider with Ukprn 49992101", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
testRunner.Then("I should get an exception when i request for a Provider which can not be found", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Roatp Register API should acknowledge existence of a provider")]
        [NUnit.Framework.CategoryAttribute("apiintegrationtests")]
        public virtual void RoatpRegisterAPIShouldAcknowledgeExistenceOfAProvider()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roatp Register API should acknowledge existence of a provider", new string[] {
                        "apiintegrationtests"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 44
testRunner.When("I request for provider with Ukprn 29992101", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
testRunner.Then("I should not get any exception when i request for an existence of Provider which " +
                    "can be found", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Roatp Register API should throw error for provider does not exist")]
        [NUnit.Framework.CategoryAttribute("apiintegrationtests")]
        public virtual void RoatpRegisterAPIShouldThrowErrorForProviderDoesNotExist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roatp Register API should throw error for provider does not exist", new string[] {
                        "apiintegrationtests"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 49
testRunner.When("I request for provider with Ukprn 49992101", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.Then("I should get an exception when i request for an existence of Provider which can n" +
                    "ot be found", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
