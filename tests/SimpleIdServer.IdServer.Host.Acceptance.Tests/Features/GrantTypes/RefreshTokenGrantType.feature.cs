﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RefreshTokenGrantTypeFeature : object, Xunit.IClassFixture<RefreshTokenGrantTypeFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "RefreshTokenGrantType.feature"
#line hidden
        
        public RefreshTokenGrantTypeFeature(RefreshTokenGrantTypeFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "RefreshTokenGrantType", "\tCheck all the alternatives scenarios in refresh_token grant-type", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="parameter resource and scope are always coming from the original request")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantType")]
        [Xunit.TraitAttribute("Description", "parameter resource and scope are always coming from the original request")]
        public void ParameterResourceAndScopeAreAlwaysComingFromTheOriginalRequest()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("parameter resource and scope are always coming from the original request", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table212 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table212.AddRow(new string[] {
                            "response_type",
                            "code"});
                table212.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table212.AddRow(new string[] {
                            "state",
                            "state"});
                table212.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table212.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table212.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table212.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
#line 6
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table212, "When ");
#line hidden
#line 16
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table213 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table213.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table213.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table213.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table213.AddRow(new string[] {
                            "code",
                            "$code$"});
                table213.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 18
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table213, "And ");
#line hidden
#line 26
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("extract parameter \'$.refresh_token\' from JSON body into \'refreshToken\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table214 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table214.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table214.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table214.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table214.AddRow(new string[] {
                            "refresh_token",
                            "$refreshToken$"});
#line 29
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table214, "And ");
#line hidden
#line 36
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then("JSON \'scope\'=\'admin calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.And("access_token audience contains \'https://cal.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("access_token contains the claim \'scope\'=\'admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("access_token contains the claim \'scope\'=\'calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RefreshTokenGrantTypeFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RefreshTokenGrantTypeFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
