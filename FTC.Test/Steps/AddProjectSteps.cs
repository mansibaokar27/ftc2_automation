using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using FTC.Framework.Utils;

using System.Threading.Tasks;

namespace FTC.Test.Steps
{
    [Binding]
    public class AddProjectSteps
    {
        [When(@"I perfom log in operation as admin")]
        public void WhenIPerfomLogInOperationAsAdmin(Table table)
        {
            string userName = table.Rows[0][1];
            string password = table.Rows[1][1];
            Objects.poLogin.EnterAdminUserName(userName);
            Objects.poLogin.EnterPassword(password);
            Objects.poLogin.ClickLogin();
        }

        [Then(@"I successfully logged in as admin and navigated to admin dashboard")]
        public void ThenISuccessfullyLoggedInAsAdminAndNavigatedToAdminDashboard()
        {
            Objects.poManageProject.VerifyLogin();
        }
        [When(@"I click on Manage Projects tab")]
        public void WhenIClickOnManageProjectsTab()
        {
            Objects.poManageProject.SelectManageProject();
        }

        [Then(@"I navigate to Manage Projects page")]
        public void ThenINavigateToManageProjectsPage()
        {
            Objects.poManageProject.verifyManageProjectPage();
        }

        [When(@"I click on Add Project button")]
        public void WhenIClickOnAddProjectButton()
        {
            Objects.poManageProject.AddProject();
        }

        [Then(@"I navigate to Create project page")]
        public void ThenINavigateToCreateProjectPage()
        {
            Objects.poManageProject.VerifyCreateProjectPage();
        }

        [When(@"I enter create project details")]
        public void WhenIEnterCreateProjectDetails()
        {
            Objects.poManageProject.SelectProjectType();
            Objects.poManageProject.SelectRecruiter();
            Objects.poManageProject.SelectPlan();
            Objects.poManageProject.EnterProjectName();
            Objects.poManageProject.CheckWhetherCastingRequired();
            Objects.poManageProject.SelectMediaBanner();
            Objects.poManageProject.SelectProductionHouse();
            Objects.poManageProject.SelectRecruitementStartDate();
            Objects.poManageProject.SelectShootDate();
            Objects.poManageProject.SelectLocation();
            Objects.poManageProject.EnterTheDescriptionOfTheProject();
         }

        [When(@"I click on save button for project creation")]
        public void WhenIClickOnSaveButtonForProjectCreation()
        {
            Objects.poManageProject.SaveCreatedProject();
        }

         [Then(@"I should be able to create the project")]
        public void ThenIShouldBeAbleToCreateTheProject()
        {
            Objects.poManageProject.VerifyTheCreatedProject();
        }

    }
}
