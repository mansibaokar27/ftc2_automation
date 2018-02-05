using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTC.Framework.Utils;
using System.Threading.Tasks;
using System.Threading;
using TechTalk.SpecFlow;



namespace FTC.Test.Steps
{
    [Binding]
    public class AddContest
    {
        #region
        [Then(@"I successfully navigate to admin dashboard")]
        public void ThenISuccessfullyNavigateToAdminDashboard()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Manage Contest tab")]
        public void WhenIClickOnManageContestTab()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I successfully naviagte to Manage contest page")]
        public void ThenISuccessfullyNaviagteToManageContestPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Add Contest button")]
        public void WhenIClickOnAddContestButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I successfully navigate to create contest page")]
        public void ThenISuccessfullyNavigateToCreateContestPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter details of create contest")]
        public void WhenIEnterDetailsOfCreateContest()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should able to save contest")]
        public void ThenIShouldAbleToSaveContest()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion
    }
}
