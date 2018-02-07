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
        [When(@"I click on Manage Contest  tab")]
        public void WhenIClickOnManageContestTab()
        {
            Objects.poManageContest.SelectManageContest();
        }

        [Then(@"I successfully naviagte to Manage contest  page")]
        public void ThenISuccessfullyNaviagteToManageContestPage()
        {
            Objects.poManageContest.VerifyManageContestPage();
        }

        [When(@"I click on Add Contest  button")]
        public void WhenIClickOnAddContestButton()
        {
            Objects.poManageContest.CreateContest();
        }

        [Then(@"I successfully navigate to create contest  page")]
        public void ThenISuccessfullyNavigateToCreateContestPage()
        {
            Objects.poManageContest.VerifyCreateContestPage();
        }

        [When(@"I enter details of  create  contest")]
        public void WhenIEnterDetailsOfCreateContest()
        {
            Objects.poManageContest.SelectCompanyName();
            Objects.poManageContest.EnterContestTitle();
            Objects.poManageContest.SelectContestType();
            Objects.poManageContest.SelectFileType();
            Objects.poManageContest.SelectContestStartDate();
            Objects.poManageContest.SelectContestEndDate();
            Objects.poManageContest.EnterContestlandingPage();
            Objects.poManageContest.SaveKeyDetailsAndContinue();
            Objects.poManageContest.EnterShortDescription();
            Objects.poManageContest.EnterLongDescription();
            Objects.poManageContest.EnterCreativeDescription();
            Objects.poManageContest.EnterGratification();
            Objects.poManageContest.UploadAsset();
            Objects.poManageContest.EnterNumberOfWinningPosition();
            Objects.poManageContest.CheckIfNeedsValidation();
            Objects.poManageContest.EnterLinkToCheckParticipationCode();
            Objects.poManageContest.EnterTermsAndContion();
            Objects.poManageContest.SaveBriefAndContinue();
            Objects.poManageContest.UploadCompanyBanner();
            //Objects.poManageContest.SelectTextColorForBanner();
            Objects.poManageContest.UploadThumnail();
        }

        [When(@"I click on save  button")]
        public void WhenIClickOnSaveButton()
        {
            Objects.poManageContest.SaveDesign();
        }

        [Then(@"I should able to  save  contest")]
        public void ThenIShouldAbleToSaveContest()
        {
            Objects.poManageContest.VerifyTheCreatedContest();
        }

        #endregion

    }
}
