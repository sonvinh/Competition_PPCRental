﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PPCRental_Project.AcceptanceTests.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PostProject")]
    public partial class PostProjectFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostProject.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostProject", "In order to avoid silly mistakes\nAs a math idiot\nI want to be told the sum of two" +
                    " numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "Content",
                        "Price",
                        "PropertyType",
                        "District",
                        "UserID",
                        "StatusID"});
            table1.AddRow(new string[] {
                        "Eckhart Tolle",
                        "The Power of Now",
                        "1200",
                        "2",
                        "3",
                        "12",
                        "3"});
            table1.AddRow(new string[] {
                        "Jeff Sutherland",
                        "Scrum: The Art of Doing Twice the Work in Half the Time",
                        "1600",
                        "3",
                        "4",
                        "1",
                        "3"});
            table1.AddRow(new string[] {
                        "Mitch Lacey",
                        "The Scrum Field Guide",
                        "1500",
                        "4",
                        "3",
                        "12",
                        "3"});
            table1.AddRow(new string[] {
                        "Martin Fowler",
                        "Analysis Patterns",
                        "5000",
                        "1",
                        "2",
                        "1",
                        "3"});
            table1.AddRow(new string[] {
                        "Eric Evans",
                        "Domain Driven Design",
                        "4600",
                        "2",
                        "4",
                        "12",
                        "3"});
            table1.AddRow(new string[] {
                        "Ted Pattison",
                        "Inside Windows SharePoint Services",
                        "3100",
                        "3",
                        "3",
                        "1",
                        "3"});
            table1.AddRow(new string[] {
                        "Lisa Crispin and Janet Gregory",
                        "Agile Testing",
                        "2000",
                        "4",
                        "2",
                        "12",
                        "3"});
            table1.AddRow(new string[] {
                        "Esther Derby and Diana Larsen",
                        "Agile Retrospectives",
                        "1600",
                        "1",
                        "4",
                        "1",
                        "3"});
#line 7
 testRunner.Given("the following property", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfull Creating New Property")]
        public virtual void SuccessfullCreatingNewProperty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfull Creating New Property", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "Content",
                        "Price",
                        "PropertyType",
                        "District",
                        "UserID",
                        "StatusID"});
            table2.AddRow(new string[] {
                        "New Create Property",
                        "Example",
                        "1200",
                        "1",
                        "2",
                        "1",
                        "3"});
#line 20
 testRunner.When("I input the following information", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "Content",
                        "Price",
                        "PropertyType",
                        "District",
                        "UserID",
                        "StatusID"});
            table3.AddRow(new string[] {
                        "Gojko Adzic",
                        "Specification By Example",
                        "1200",
                        "1",
                        "2",
                        "1",
                        "3"});
            table3.AddRow(new string[] {
                        "Eckhart Tolle",
                        "The Power of Now",
                        "1200",
                        "2",
                        "3",
                        "12",
                        "3"});
            table3.AddRow(new string[] {
                        "Jeff Sutherland",
                        "Scrum: The Art of Doing Twice the Work in Half the Time",
                        "1600",
                        "3",
                        "4",
                        "1",
                        "3"});
            table3.AddRow(new string[] {
                        "Mitch Lacey",
                        "The Scrum Field Guide",
                        "1500",
                        "4",
                        "3",
                        "12",
                        "3"});
            table3.AddRow(new string[] {
                        "Martin Fowler",
                        "Analysis Patterns",
                        "5000",
                        "1",
                        "2",
                        "1",
                        "3"});
            table3.AddRow(new string[] {
                        "Eric Evans",
                        "Domain Driven Design",
                        "4600",
                        "2",
                        "4",
                        "12",
                        "3"});
            table3.AddRow(new string[] {
                        "Ted Pattison",
                        "Inside Windows SharePoint Services",
                        "3100",
                        "3",
                        "3",
                        "1",
                        "3"});
            table3.AddRow(new string[] {
                        "Lisa Crispin and Janet Gregory",
                        "Agile Testing",
                        "2000",
                        "4",
                        "2",
                        "12",
                        "3"});
            table3.AddRow(new string[] {
                        "Esther Derby and Diana Larsen",
                        "Agile Retrospectives",
                        "1600",
                        "1",
                        "4",
                        "1",
                        "3"});
            table3.AddRow(new string[] {
                        "New Create Property",
                        "Example",
                        "1200",
                        "1",
                        "2",
                        "1",
                        "3"});
#line 23
 testRunner.Then("the list of books should update", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion