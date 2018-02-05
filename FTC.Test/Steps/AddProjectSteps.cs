using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

using System.Threading.Tasks;

namespace FTC.Test.Steps
{
    [Binding]
    public class AddProjectSteps
    {
        [When(@"I navigate to admin dashboard")]
        public void WhenINavigateToAdminDashboard()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Manage Projects tab")]
        public void WhenIClickOnManageProjectsTab()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I navigate to Manage Projects page")]
        public void ThenINavigateToManageProjectsPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Add Project button")]
        public void WhenIClickOnAddProjectButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I navigate to Manage project page")]
        public void ThenINavigateToManageProjectPage()
        {
            ScenarioContext.Current.Pending();
        }
        [When(@"I enter create project details")]
        public void WhenIEnterCreateProjectDetails()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I should be able to create the project")]
        public void ThenIShouldBeAbleToCreateTheProject()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
