using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FTC.Framework.PageObject
{
   public class PageObjectManageContest
    {
        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;
    public PageObjectManageContest(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[title='Manage Contests']")]
        public IWebElement btnManageContest { get; set; }

        [FindsBy(How = How.CssSelector, Using = " div.col-md-7.col-sm-6.col-xs-12.text-right > form > a")]
        public IWebElement btnCreateContest { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='auxiliaryUserId']")]
        public IWebElement ddCompanyName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Contest Title']")]
        public IWebElement txtContestTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='contestType']")]
        public IWebElement ddContestType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='fileType']")]
        public IWebElement ddFileType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "  form > div > div > div > div > div > div > div:nth-child(10) > div:nth-child(1) > div > div > div")]
        public IWebElement ddContestStartDate { get; set; }
      

       [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-navigation-select > select:nth-child(1)")]
        public IWebElement ddMonth { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-navigation-select > select:nth-child(2)")]
        public IWebElement ddYear { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-month-view > div:nth-child(4) > div:nth-child(3) > div")]
        public IWebElement ddDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = " form > div > div > div > div > div > div > div:nth-child(10) > div:nth-child(2) > div > div > div")]
        public IWebElement ddContestEndDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='engagementLink']")]
        public IWebElement txtContestLandingPage { get; set; }

        [FindsBy(How = How.CssSelector, Using = " form > div > div > div > div > div > div > button:nth-child(18)")]
        public IWebElement btnSaveKeyDetailsAndContinue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Short Description']")]
        public IWebElement txtShortDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[placeholder='Long Description']")]
        public IWebElement txtLongDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[placeholder='Creative Direction']")]
        public IWebElement txtCreativeDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[placeholder='Gratification']")]
        public IWebElement txtGratification { get; set; }

        [FindsBy(How = How.Id, Using = "uploadAssets")]
        public IWebElement uploadMediaFile { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='numberOfWinner']")]
        public IWebElement txtNumberOfWinningPositions { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='needValidation']")]
        public IWebElement chckboxIfNeedsValidation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='value']")]
        public IWebElement txtLinkToCheckparticipationCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='termsConditions']")]
        public IWebElement txtTermAndCondition { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.contest-keydetails.ng-dirty.ng-touched.ng-valid > button")]
        public IWebElement btnSaveBriefsAndContinue { get; set; }

        [FindsBy(How = How.Id, Using = "ChangeBanner")]
        public IWebElement uploadCompanyBanner { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.contest-keydetails > div:nth-child(6) > div > span")]
        public IWebElement selectTextColor{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "color-picker > div > div.saturation-lightness > div")]
        public IWebElement selectRandomClickforTextColor { get; set; }

        [FindsBy(How = How.CssSelector, Using = " color-picker > div > div.button-area > button")]
        public IWebElement btnCloseTheColorBox { get; set; }

        [FindsBy(How = How.Id, Using = "uploadThumbnail")]
        public IWebElement uploadThumbnail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.contest-keydetails > button:nth-child(14)")]
        public IWebElement btnSaveDesign { get; set; }

        [FindsBy(How = How.CssSelector, Using = "form > div > div > div > div > div > div.contest-keydetails > button:nth-child(13)")]
        public IWebElement btnSaveAndPreview { get; set; }


        public void VerifyNavigationToAdminPage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("sd-admin-dashboard > admin-header > div.manage-recruiter-background-.recuiter-background")));
            Thread.Sleep(2000);
            string adminPage = driver.FindElement(By.CssSelector("h1.manage-recruiter-name")).Text;
            Assert.AreEqual("FTC ADMIN", adminPage);
        }
        public void SelectManageContest()
        {
            btnManageContest.Click();
           
        }
        public void VerifyManageContestPage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.col-md-9.main-content.admin-manage-box")));
            Thread.Sleep(2000);
            string manageContest = driver.FindElement(By.CssSelector("h4.manage-contest-title")).Text;
            Assert.AreEqual("Manage Contests", manageContest);
        }

        public void CreateContest()
        {
            btnCreateContest.Click();
        }

        public void VerifyCreateContestPage()
        {  
            Assert.AreEqual(true, driver.FindElement(By.CssSelector("[formcontrolname='auxiliaryUserId']")).Enabled);
         }

        public void SelectCompanyName()
        {
            ddCompanyName.Click();
            SelectElement companyName = new SelectElement(ddCompanyName);
            companyName.SelectByValue("55");
            ddCompanyName.Click();

        }

        public void EnterContestTitle()
        {
            txtContestTitle.SendKeys("Year2018Contest");
        }

        public void SelectContestType()
        {
            ddContestType.Click();
            SelectElement contestType = new SelectElement(ddContestType);
            contestType.SelectByValue("3");
            ddContestType.Click();
        }

        public void SelectFileType()
        {
            ddFileType.Click();
            SelectElement fileType = new SelectElement(ddFileType);
            fileType.SelectByText("Script");
            ddFileType.Click();
        }

        public void SelectContestStartDate()
        {
            ddContestStartDate.Click();
            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("3");
            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("2018");
            ddDay.Click();
         }

        public void SelectContestEndDate()
        {
            ddContestEndDate.Click();
            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("4");
            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("2018");
            ddDay.Click();
        }

        public void EnterContestlandingPage()
        {
            txtContestLandingPage.SendKeys("http://eac7q5systest.fthecouch.com/portal/account/signin");
        }

        public void SaveKeyDetailsAndContinue()
        {
            btnSaveKeyDetailsAndContinue.Click();
        }

        public void EnterShortDescription()
        {
            txtShortDescription.SendKeys("For_New_Talents");
        }

        public void EnterLongDescription()
        {
            txtLongDescription.SendKeys("Big Chance for the new Talents");
        }

        public void EnterCreativeDescription()
        {
            txtCreativeDescription.SendKeys("The auditions of Star Plus India’s Next SuperStar will take place across India.");
        }

        public void EnterGratification()
        {
            txtGratification.SendKeys("A chance to act as a lead in Karan Johar's next");
        }

        public void UploadAsset()
        {
            uploadMediaFile.SendKeys(@"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg");
        }

        public void EnterNumberOfWinningPosition()
        {
            txtNumberOfWinningPositions.SendKeys("3");
        }

        public void CheckIfNeedsValidation()
        {
            IWebElement needsValidation = driver.FindElement(By.CssSelector("[formcontrolname='needValidation']"));
             needsValidation.Click();
        }

        public void EnterLinkToCheckParticipationCode()
        {
            txtLinkToCheckparticipationCode.SendKeys("http://eac7q5systest.fthecouch.com/portal/account/signin");
        }

        public void EnterTermsAndContion()
        {
            txtTermAndCondition.SendKeys("Age Should be between 18 to 30 or else won't be selected");
        }

        public void SaveBriefAndContinue()
        {
             btnSaveBriefsAndContinue.Click();
        }

        public void UploadCompanyBanner()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[title='Change Banner']")));
            uploadCompanyBanner.SendKeys(@"C:\Users\Public\Pictures\Sample Pictures\Lighthouse.jpg");
            Thread.Sleep(2000);
        }

        //public void SelectTextColorForBanner()
        //{
        //    selectTextColor.Click();
        //    selectRandomClickforTextColor.Click();
        //    iWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(" color-picker > div > div.button-area > button")));
        //    btnCloseTheColorBox.Click();
        //}

        public void UploadThumnail()
        {
            uploadThumbnail.SendKeys(@"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg");
            Thread.Sleep(2000);
        }


        public void SaveDesign()
        {
            Thread.Sleep(3000);
            btnSaveDesign.Click();
        }

       

        public void VerifyTheCreatedContest()
        {
            Thread.Sleep(3000);
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#toast-container > div > div.toast-content > div.toast-message > div")));
            string contestCreated = driver.FindElement(By.CssSelector("#toast-container > div > div.toast-content > div.toast-message > div")).Text;
            Assert.AreEqual("Contest saved successfully. Please publish contest to make it available for participate.", contestCreated);
        }

    }
}
