using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Project;
namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public class UC04_PostProject
    {
        private readonly ProjectDriver  _projectDriver;
        public UC04_PostProject (ProjectDriver _ProjectDriver)
        {
            _ProjectDriver = _projectDriver;
        }

        [Given(@"the following project")]
        public void GivenTheFollowingProject(Table table)
        {
            _projectDriver.InsertProjecttoDB(table);
        }

        [Given(@"I am on Create Book Page")]
        public void GivenIAmOnCreateBookPage()
        {
            _projectDriver.NavigateCreateBook();
        }

        [When(@"I input the following information")]
        public void WhenIInputTheFollowingInformation(Table table1)
        {
            _projectDriver.CreateProperty(table1);
        }

        [When(@"I upload Avatar for this property: '(.*)'")]
        public void WhenIUploadAvatarForThisProperty(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I upload images for this property: '(.*)','(.*)'")]
        public void WhenIUploadImagesForThisProperty(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the list property update")]
        public void ThenTheListPropertyUpdate(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"The Avatar should upload on server")]
        public void TheAvatarshoulduploadonServer()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"The Images should upload on server")]
        public void ThenTheImagesShouldUploadOnServer()
        {
            ScenarioContext.Current.Pending();
        }
    }

    }
}
