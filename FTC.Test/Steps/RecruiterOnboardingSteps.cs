using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using FTC.Framework.Utils;
using System.Configuration;
using System.Threading;
namespace FTC.Test.Steps
{
    [Binding]
    public class RecruiterOnboardingSteps
    {
        #region
        String username = null;
        String password = null;

        [Given(@"I login into FTC home page")]
        public void GivenILoginIntoFTCHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter login id as ""(.*)""")]
        public void WhenIEnterLoginIdAs(string username)
        {
            this.username = username;
            Objects.poLogin.EnterUsername(username);
        }

        [Then(@"I eneter password as ""(.*)""")]
        public void ThenIEneterPasswordAs(string password)
        {
            this.password = password;
            Objects.poLogin.EnterPassword(password);
        }
        
        [Then(@"I click on login button")]
        public void ThenIClickOnLoginButton()
        {
            Objects.poLogin.ClickLogin();
        }

        [Then(@"I select ""(.*)"" option from right side dropdown")]
        public void ThenISelectOptionFromRightSideDropdown(string profile)
        {
            Objects.poDashboard.selectProfile();
        }

        [Then(@"I click on Next button")]
        public void ThenIClickOnNextButton()
        {
            Objects.poProfileTab.clickOnNext();
        }

        [Then(@"I enter the company name")]
        public void ThenIEnterTheCompanyName()
        {
            Objects.poProfileTab.enterCompanyName();
        }
        
        [Then(@"I enter recruiter name")]
        public void ThenIEnterRecruiterName()
        {
            Objects.poProfileTab.enterRecruiterName();
        }
        
        [Then(@"I enter email id")]
        public void ThenIEnterEmailId()
        {
            Objects.poProfileTab.enterEmailId();
        }
        
        [Then(@"I enter city")]
        public void ThenIEnterCity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I select ""(.*)"" from Recruiter type dropdwon")]
        public void ThenISelectFromRecruiterTypeDropdwon(string p0)
        {
            ScenarioContext.Current.Pending();
        }    
        
        [Then(@"I click on Add button on Work experience tab")]
        public void ThenIClickOnAddButtonOnWorkExperienceTab()
        {
            Objects.poWorkExpTab.DeleteAllWorks();
            Objects.poAwardRecog.AddAnAward();
        }
        
        [Then(@"I select ""(.*)"" from Project type dropdown")]
        public void ThenISelectFromProjectTypeDropdown()
        {
            Objects.poWorkExpTab.AddPtypedropdown();
        }
        
        [Then(@"I enter the Project title")]
        public void ThenIEnterTheProjectTitle()
        {
            Objects.poWorkExpTab.addtitle();
        }
        
        [Then(@"I enter the production name")]
        public void ThenIEnterTheProductionName()
        {
            Objects.poWorkExpTab.addPname();
        }
        
        [Then(@"I enter the year")]
        public void ThenIEnterTheYear()
        {
            Objects.poWorkExpTab.addYear();
        }
          
        [Then(@"I click on Add button on Awards and Recognitions tab")]
        public void ThenIClickOnAddButtonOnAwardsAndRecognitionsTab()
        {
            Objects.poWorkExpTab.DeleteAllWorks();
            Objects.poWorkExpTab.AddWorks();
        }
        
        [Then(@"I enter Award title")]
        public void ThenIEnterAwardTitle()
        {
           //
        }
        
        [Then(@"I enter Award for")]
        public void ThenIEnterAwardFor()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter Award year")]
        public void ThenIEnterAwardYear()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on Add button on Social Links tab")]
        public void ThenIClickOnAddButtonOnSocialLinksTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter facebook link")]
        public void ThenIEnterFacebookLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter Twitter link")]
        public void ThenIEnterTwitterLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter instagram link")]
        public void ThenIEnterInstagramLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter Youtube link")]
        public void ThenIEnterYoutubeLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter Website link")]
        public void ThenIEnterWebsiteLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter IMDB link")]
        public void ThenIEnterIMDBLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on next button on Social Links tab")]
        public void ThenIClickOnNextButtonOnSocialLinksTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on Add button on Associations tab")]
        public void ThenIClickOnAddButtonOnAssociationsTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I select ""(.*)"" from Association Name dropdown")]
        public void ThenISelectFromAssociationNameDropdown(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter Association ID")]
        public void ThenIEnterAssociationID()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter Childhood name")]
        public void ThenIEnterChildhoodName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter favourite childhood friend")]
        public void ThenIEnterFavouriteChildhoodFriend()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter favourite team")]
        public void ThenIEnterFavouriteTeam()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter favourite player")]
        public void ThenIEnterFavouritePlayer()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter favourite movie")]
        public void ThenIEnterFavouriteMovie()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter first job")]
        public void ThenIEnterFirstJob()
        {
            ScenarioContext.Current.Pending();
        }
        #endregion

        #region

        [When(@"I perfom log in operation")]
        public void WhenIPerfomLogInOperation(Table table)
        {
            string userName = table.Rows[0][1];
            string password = table.Rows[1][1];
            Objects.poLogin.EnterUsername(userName);
            Objects.poLogin.EnterPassword(password);
            Objects.poLogin.ClickLogin();
        }

        [Then(@"I successfully logged in")]
        public void ThenISuccessfullyLoggedIn()
        {
            Objects.poDashboard.verifylogin();
        }

        [When(@"I navigate to my profile")]
        public void WhenINavigateToMyProfile()
        {
            Objects.poDashboard.selectProfile();
        }

        [When(@"I edit my profile tab")]
        public void WhenIEditMyProfileTab()
        {
            Objects.poProfileTab.enterCompanyName();
            Objects.poProfileTab.enterRecruiterName();
            Objects.poProfileTab.enterEmailId();   
        }

        [When(@"I click on next button")]
        public void WhenIClickOnNextButton()
        {
            Thread.Sleep(2000);
            Objects.poProfileTab.clickOnNext();
        }

        [Then(@"I successfully navigate to Work experinece tab")]
        public void ThenISuccessfullyNavigateToWorkExperineceTab()
        {
            Objects.poWorkExpTab.verifyWorkExppage();
        }

        [When(@"I Add Work experience")]
        public void WhenIAddWorkExperience()
        {
            Objects.poWorkExpTab.DeleteAllWorks();
            Objects.poAwardRecog.AddAnAward();
            Objects.poWorkExpTab.AddPtypedropdown();
            Objects.poWorkExpTab.addtitle();
            Objects.poWorkExpTab.addPname();
            Objects.poWorkExpTab.addYear();

        }

        [Then(@"I successfully navigate to Awards and Recognitions tab")]
        public void ThenISuccessfullyNavigateToAwardsAndRecognitionsTab()
        {
            Objects.poAwardRecog.verifyAwardpage();
        }

        [When(@"I Add Awards and Recognitions")]
        public void WhenIAddAwardsAndRecognitions(Table table)
        {
            Objects.poAwardRecog.DeleteAllAwards();
            Objects.poAwardRecog.AddAnAward();
            string title = table.Rows[0][1];
            string awardfor = table.Rows[1][1];
            string year = table.Rows[2][1];
            Objects.poAwardRecog.AddAwardTitle(title, awardfor, year);
        }

        [Then(@"I successfully navigate to Social links tab")]
        public void ThenISuccessfullyNavigateToSocialLinksTab()
        {
            Objects.poSociallinks.verifysocialpage();
        }

        [When(@"I Add Social links")]
        public void WhenIAddSocialLinks(Table table)
        {
            Objects.poSociallinks.EnterFbDetails();
            Objects.poSociallinks.EnterTwitterDetails();
            Objects.poSociallinks.EnterInstagramDetails();
            Objects.poSociallinks.EnterYouTubeDetails();
            Objects.poSociallinks.EnterPersonalWebsiteDetails();
            Objects.poSociallinks.EnterIMDBDetails();
        }

        [Then(@"I successfully navigate to Associations tab")]
        public void ThenISuccessfullyNavigateToAssociationsTab()
        {
            Objects.poassosication.verifyAssosicationExppage();
        }

        [When(@"I Add Associations")]
        public void WhenIAddAssociations(Table table)
        {
            Objects.poassosication.DeleteAllAssociates();
            Objects.poassosication.AddAssociation();
            Objects.poassosication.SelectAssociationName();
            Objects.poassosication.EnterAssociationId();
        }

        [Then(@"I successfully navigate to Security Questions  tab")]
        public void ThenISuccessfullyNavigateToSecurityQuestionsTab()
        {
            Objects.posecurityquestions.verifysecuritypage();
        }

        [When(@"I Add  Security Questions")]
        public void WhenIAddSecurityQuestions(Table table)
        {
            Thread.Sleep(2000);
            string Namenickname = table.Rows[0][1];
            string friend = table.Rows[1][1];
            string team = table.Rows[2][1];
            //string movie = table.Rows[3][1];
           // string job = table.Rows[4][1]; 
            Objects.posecurityquestions.EnterChildhoodName(Namenickname);
            Objects.posecurityquestions.EnterChildhoodFriend(friend);
            Objects.posecurityquestions.EnterFavouriteTeam(team);
          //  Objects.posecurityquestions.EnterFavouriteMovie(movie);
         //   Objects.posecurityquestions.EnterFirstJob(job);
        }   

        [Then(@"I successfully navigate to dashboard")]
        public void ThenISuccessfullyNavigateToDashboard()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I successfully navigate to profile page")]
        public void ThenISuccessfullyNavigateToProfilePage()
        {
            //Objects.poProfileTab.verifyprofilepage();
        }

        #endregion
    }

}
