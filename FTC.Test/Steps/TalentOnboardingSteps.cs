using System;
using TechTalk.SpecFlow;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTC.Framework.Utils;

using System.Threading.Tasks;

namespace FTC.Test.Steps
{
    [Binding]
    public class TalentOnboardingSteps
    {
        [When(@"I click on Edit profile button")]
        public void WhenIClickOnEditProfileButton()
        {
            //Objects.poPersonalDetail.HitCompleteProfileTab();
            Objects.poDashboard.clickonEditProfile();
        }

        [Then(@"I successfully navigate to personal details page")]
        public void ThenISuccessfullyNavigateToPersonalDetailsPage()
        {
            Objects.poPersonalDetail.VerifyPersonalDetailsPage();
        }

        [When(@"I edit personal details tab")]
        public void WhenIEditPersonalDetailsTab()
        {
            Objects.poPersonalDetail.EnterName();
            Objects.poPersonalDetail.EnterDateOfBirthLessThan18();
            Objects.poPersonalDetail.EnterCity();
            Objects.poProfileTab.clickOnNext();
            Objects.poPersonalDetail.EnterNameOfGuardian();
            Objects.poPersonalDetail.EnterRelationWithGuardian();
            Objects.poPersonalDetail.EnterMobileNumberOfGuardian();
            Objects.poPersonalDetail.EnterGuardianEmailID();
        }

        [Then(@"I successfully navigate to Talent page")]
        public void ThenISuccessfullyNavigateToTalentPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit Talent page")]
        public void WhenIEditTalentPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I successfully navigate to Interest page")]
        public void ThenISuccessfullyNavigateToInterestPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit Interest page")]
        public void WhenIEditInterestPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I successfully navigate to skills page")]
        public void ThenISuccessfullyNavigateToSkillsPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit skill page")]
        public void WhenIEditSkillPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I successfully navigate to Attributes page")]
        public void ThenISuccessfullyNavigateToAttributesPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit Attributes page")]
        public void WhenIEditAttributesPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I successfully navigate to Media page")]
        public void ThenISuccessfullyNavigateToMediaPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit media page")]
        public void WhenIEditMediaPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I successfully navigate to Experience page")]
        public void ThenISuccessfullyNavigateToExperiencePage()
        {
            Objects.poExperience.VerifyExperiencePage();
        }

        [When(@"I perform Login operation as talent")]
        public void WhenIPerformLoginOperationAsTalent(Table table)
        {
            string userName = table.Rows[0][1];
            string password = table.Rows[1][1];
            Objects.poLogin.EnterUsername(userName);
            Objects.poLogin.EnterPassword(password);
            Objects.poLogin.ClickLogin();
        }

        [Then(@"I successfully logged in as talent")]
        public void ThenISuccessfullyLoggedInAsATalent()
        {
            Objects.poDashboard.verifylogin();
        }

        [When(@"I edit Experience page")]
        public void WhenIEditExperiencePage()
        {
            Objects.poExperience.DeleteAllExperiences();
            Objects.poExperience.AddExperience();
            Objects.poExperience.SelectInterestType();
            Objects.poExperience.SelectSkillType();
            Objects.poExperience.SelectProductionHouse();
            Objects.poExperience.EnterProjectTitle();
            Objects.poExperience.EnterProjectRole();
            Objects.poExperience.EnterProjectYear();
        }
        [Then(@"I successfully navigate to Education page")]
        public void ThenISuccessfullyNavigateToEducationPage()
        {
            Objects.poEducation.VerifyEducationPage();
        }

        [When(@"I edit Education page")]
        public void WhenIEditEducationPage()
        {
            Objects.poEducation.DeleteAllEducation();
            Objects.poEducation.AddEducation();
            Objects.poEducation.SelectSchool();
            Objects.poEducation.EnterCourseCompleted();
            Objects.poEducation.EnterCourseCompletionYear();
            Objects.poEducation.EnterCourseCompletedFromCity();
            Objects.poEducation.EnterCourseCompletedFromCountry();
        }
        [Then(@"I succesfully navigate to Additional page")]
        public void ThenISuccesfullyNavigateToAdditionalPage()
        {
            Objects.poAdditional.VerifyAdditionaPage();
        }

        [When(@"I edit Additional page")]
        public void WhenIEditAdditionalPage()
        {
            Objects.poAdditional.DeleteAllAssociates();
            Objects.poAdditional.AddAssociation();
            Objects.poAdditional.SelectAssociationName();
            Objects.poAdditional.EnterAssociationId();
            Objects.poAdditional.HitPassportTab();
            Objects.poAdditional.SelectPassportCountry();
            Objects.poAdditional.SelectExpirationDate();
            Objects.poAdditional.EnterVisaType();
            Objects.poAdditional.EnterVisaYear();
            Objects.poAdditional.HitAgencyTab();
            Objects.poAdditional.SelectAgencyName();
            Objects.poAdditional.EnterAgentName();
            Objects.poAdditional.EnterAgencyStartDate();
            Objects.poAdditional.EnterAgencyEndDate();
            Objects.poAdditional.EnterAgentMobileNumber();
            Objects.poAdditional.EnterAgentEmailId();
            Objects.poAdditional.HitBudgetTab();
            Objects.poAdditional.EnterMinimumCompensation();
            Objects.poAdditional.EnterMaximumCompensation();
            Objects.poAdditional.HitSecurityQuestionTab();
            Objects.poAdditional.EnterChildhoodName();
            Objects.poAdditional.EnterChildhoodFriend();
            Objects.poAdditional.EnterFavouriteTeam();
            Objects.poAdditional.HitAboutMeTab();
            Objects.poAdditional.EnterAboutMe();
        }
    }
}
