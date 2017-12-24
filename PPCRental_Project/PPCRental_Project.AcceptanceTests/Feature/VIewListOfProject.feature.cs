﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class VIewListOfProjectFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "VIewListOfProject.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "VIewListOfProject", "\tI want to view list of project", ProgrammingLanguage.CSharp, new string[] {
                        "automated"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "VIewListOfProject")))
            {
                global::PPCRental_Project.AcceptanceTests.Feature.VIewListOfProjectFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
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
                        "Avarta",
                        "Images",
                        "PropertyType",
                        "Content",
                        "Street",
                        "Ward",
                        "District",
                        "Price",
                        "UnitPrice",
                        "Area",
                        "BedRoom",
                        "BathRoom",
                        "PackingPlace",
                        "UserID",
                        "Create_at",
                        "Create_post",
                        "Status",
                        "Note",
                        "Update_at",
                        "Sale_ID"});
            table1.AddRow(new string[] {
                        "PIS Top Apartment",
                        "PIS_6656-Edit-stamp.jpg",
                        "a17584387317552326.jpg,AvatarNone17100766117552327.png,images1709523917552328.jpg" +
                            ",",
                        "Apartment",
                        "The surrounding neighborhood is very much localized with a great number of local " +
                            "shops.",
                        "Cô Bắc",
                        "P.Cô Giang",
                        "Q.1",
                        "10000",
                        "VND",
                        "120m2",
                        "3",
                        "2",
                        "1",
                        "1",
                        "2017-11-09",
                        "2017-11-09",
                        "Ðã duyệt",
                        "Done",
                        "2017-11-23",
                        "2"});
            table1.AddRow(new string[] {
                        "ViLa Q7",
                        "images172300301.jpg",
                        "images172300301.jpg",
                        "Villa",
                        "Brand new apartments with unbelievable river and city view, completely renovated " +
                            "and tastefully furnished.",
                        "Nguyễn Thị Thập",
                        "P.Phú Mỹ",
                        "Q.7",
                        "70000",
                        "VND",
                        "120m2",
                        "3",
                        "4",
                        "1",
                        "1",
                        "2017-11-09",
                        "2017-11-09",
                        "Ðã duyệt",
                        "Done",
                        "2017-11-23",
                        "2"});
            table1.AddRow(new string[] {
                        "PIS Serviced Apartment – Style",
                        "sunshine-benthanh-cityhome-10-stamp174228283.jpg",
                        "a - Copy17095239.jpg,images (1) - Copy17095242.jpg,images17095242.jpg,",
                        "Office",
                        "The well equipped kitchen is opened on a cozy living room and a dining area with " +
                            "table and chairs..",
                        "Bến Vân Ðồn",
                        "P.03",
                        "Q.4",
                        "30000",
                        "VND",
                        "130m2",
                        "2",
                        "3",
                        "1",
                        "4",
                        "2017-11-09",
                        "2017-11-09",
                        "Ðã duyệt",
                        "Done",
                        "2017-11-23",
                        "3"});
            table1.AddRow(new string[] {
                        "Vinhomes Central Park L2 – Duong’s Apartment",
                        "PIS_7389-Edit-stamp.jpg",
                        "images1702244617042862.jpg,",
                        "Villa",
                        "Vinhomes Central Park is a new development that is in the heart of everything tha" +
                            "t Ho Chi Minh has to offer.",
                        "Bà Hạt",
                        "P.02",
                        "Q.10",
                        "110000",
                        "VND",
                        "150m2",
                        "4",
                        "2",
                        "1",
                        "1",
                        "2017-11-09",
                        "2017-11-09",
                        "Ðã duyệt",
                        "Done",
                        "2017-11-23",
                        "3"});
            table1.AddRow(new string[] {
                        "Saigon Pearl Ruby Block",
                        "PIS_7319-Edit-stamp.jpg",
                        "images17423697317334243.jpg,PIS_4622-Edit17463610217334244.jpg,",
                        "Apartment",
                        "Studio apartment at central of CBD, nearby Ben Thanh market, Bui Vien Backpacker " +
                            "Area, 23/9 park…",
                        "Chu Van An",
                        "P.Long Bình",
                        "Q.9",
                        "30000",
                        "VND",
                        "130m2",
                        "3",
                        "5",
                        "1",
                        "4",
                        "2017-11-09",
                        "2017-11-09",
                        "Ðã duyệt",
                        "Done",
                        "2017-11-23",
                        "2"});
#line 7
 testRunner.Given("the following project", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "FullName",
                        "Phone",
                        "Address",
                        "Role",
                        "Status"});
            table2.AddRow(new string[] {
                        "lythihuyenchau@gmail.com",
                        "123456",
                        "Ly Chau",
                        "0999580654",
                        "Nguyễn Khắc Nhu",
                        "1",
                        "True"});
            table2.AddRow(new string[] {
                        "phamcongduc@gmail.com",
                        "123",
                        "Duc Pham",
                        "068451685",
                        "Quan 3",
                        "0",
                        "True"});
            table2.AddRow(new string[] {
                        "nguyensonvinh@gmail.com",
                        "123456Sa",
                        "son vinh",
                        "123456",
                        "quan 4",
                        "1",
                        "False"});
            table2.AddRow(new string[] {
                        "nguyentuankiet@gmail.com",
                        "123456",
                        "Kiet Nguyen",
                        "012121212",
                        "Quan 1",
                        "2",
                        "True"});
#line 14
 testRunner.And("the following user", ((string)(null)), table2, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("View List Of Project")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VIewListOfProject")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void ViewListOfProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View List Of Project", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 22
 testRunner.When("I input \'lythihuyenchau@gmail.com\' and \'123456\' into Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName"});
            table3.AddRow(new string[] {
                        "PIS Top Apartment"});
            table3.AddRow(new string[] {
                        "ViLa Q7"});
            table3.AddRow(new string[] {
                        "Vinhomes Central Park L2 – Duong’s Apartment"});
#line 23
 testRunner.Then("I should see my own projects", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
