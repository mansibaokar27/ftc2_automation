using System;
using TechTalk.SpecFlow;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTC.Framework.Utils;

using System.Threading.Tasks;

namespace FTC.Test.Steps
{
    public class TalentOnboardingSteps
    {
        [When(@"I click on Edit profile button")]
        public void WhenIClickOnEditProfileButton()
        {
            Objects.poDashboard.clickonEditProfile();
        }

        [Then(@"I successfully navigate to personal details page")]
        public void ThenISuccessfullyNavigateToPersonalDetailsPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit personal details tab")]
        public void WhenIEditPersonalDetailsTab()
        {
            ScenarioContext.Current.Pending();
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
            ScenarioContext.Current.Pending();
        }

    }
}
