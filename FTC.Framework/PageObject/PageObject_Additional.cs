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

namespace FTC.Framework.PageObjects
{
   public  class PageObject_Additional
    {

        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;


        public PageObject_Additional(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;

            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "div.wizard-inner > ul > li:nth-child(9) > a > span")]
        public IWebElement btnAdditionalTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[title|='Delete']")]
        public IWebElement btnDeleteAssociates; //This for deleting your respective span

        [FindsBy(How = How.CssSelector, Using = " div.col-md-2.col-sm-2.col-xs-12.text-right > div > a")]
        public IWebElement btnAddAssociation { get; set; }


        [FindsBy(How = How.CssSelector, Using = "md-select > div")]
        public IWebElement ddAssociationName { get; set; }

        [FindsBy(How = How.ClassName, Using = "mat-option")]
        public IList<IWebElement> ddSelectAssociationsName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='membershipId']")]

        public IWebElement txtEnterAssociationId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ul.nav.nav-tabs.justify-content-start li:nth-child(2)")]
        public IWebElement btnPassportTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.mat-select-placeholder")]
        public IWebElement ddPassportCountry { get; set; }


        [FindsBy(How = How.ClassName, Using = "mat-option")]
        public IList<IWebElement> ddSelectPassportCountry { get; set; }

        [FindsBy(How = How.CssSelector, Using = "img.angular-date-img")]
        public IWebElement ddExpirationDate;


        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-navigation-select > select:nth-child(1)")]
        public IWebElement ddMonth;


        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-navigation-select > select:nth-child(2)")]
        public IWebElement ddYear;

        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-month-view > div:nth-child(4) > div:nth-child(3) > div")]
        public IWebElement ddDay;



        [FindsBy(How = How.CssSelector, Using = "[placeholder|='Visa Type']")]
        public IWebElement txtVisaType;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='Visa Year']")]
        public IWebElement txtVisaYear;

        [FindsBy(How = How.CssSelector, Using = "ul.nav.nav-tabs.justify-content-start li:nth-child(3)")]
        public IWebElement btnAgencyTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.mat-select-placeholder")]
        public IWebElement ddAgencyName { get; set; }


        [FindsBy(How = How.ClassName, Using = "mat-option")]
        public IList<IWebElement> ddSelectAgencyName{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "[placeholder='Agent /Representative Name']")]
        public IWebElement txtAgentName;



        [FindsBy(How = How.CssSelector, Using = " div:nth-child(2) > div:nth-child(3) > div > img")]
        public IWebElement ddAgencyStartDate;

        [FindsBy(How = How.CssSelector, Using = "div.col-md-2.col-sm-6.col-xs-12 > div > img")]
        public IWebElement ddAgencyEndDate;




        [FindsBy(How = How.CssSelector, Using = "[placeholder='Agent /Representative Mobile No.']")]
        public IWebElement txtAgentMobileNumber;

        [FindsBy(How = How.CssSelector, Using = "[placeholder='Agent /Representative Email ID']")]
        public IWebElement txtAgentEmailId;


        [FindsBy(How = How.CssSelector, Using = "ul.nav.nav-tabs.justify-content-start li:nth-child(4)")]
        public IWebElement btnBudgetTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='budgetMin']")]
        public IWebElement txtMinimumCompensation;

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='budgetMax']")]
        public IWebElement txtMaximumCompensation;

        [FindsBy(How = How.CssSelector, Using = "ul.nav.nav-tabs.justify-content-start li:nth-child(5)")]
        public IWebElement btnSecurityQuestionTab { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Your childhood nickname?']")]
        public IWebElement txtEnterChildhoodName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Your favourite childhood friend?']")]
        public IWebElement txtEnterChildhoodFriend { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Your favourite team?']")]
        public IWebElement txtEnterFavouriteTeam { get; set; }


        [FindsBy(How = How.CssSelector, Using = "ul.nav.nav-tabs.justify-content-start li:nth-child(6)")]
        public IWebElement btnAboutMeTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='aboutMe']")]
        public IWebElement txtAboutMe;

        [FindsBy(How = How.CssSelector, Using = "#complete > form > ul > li > button:nth-child(3)")]
        public IWebElement btnNext { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#complete > form > ul > li > button.btn.onboarding-step.skip-step")]
        public IWebElement btnSkip { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href='/portal/talent/dashboard']")]
        public IWebElement btnViewDashboard;


        public void HitAdditionalTab()
        {
            btnAdditionalTab.Click();
        }

        public void VerifyAdditionaPage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[role='tabpanel']")));
            Thread.Sleep(2000);
            string additional= driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Additional", additional);
        }

        public void DeleteAllAssociates()
        {
            int count = driver.FindElements(By.CssSelector("div.project-title-box > span")).Count();

            for (int i = count; i >= 1; i--)
            {
                btnDeleteAssociates.Click();
            }
        }

        public void AddAssociation()

        {
          btnAddAssociation.Click();
        }

        public void SelectAssociationName()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span.mat-select-placeholder")));
            ddAssociationName.Click();
            ddSelectAssociationsName[2].Click();
        }

        public void EnterAssociationId()
        {
            txtEnterAssociationId.SendKeys("12345");
        }

        public void HitPassportTab()
        {
            btnPassportTab.Click();
        }

        public void SelectPassportCountry()
        {
            iWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.mat-select-placeholder")));
            ddPassportCountry.Click();
            ddSelectPassportCountry[2].Click();
        }

        public void SelectExpirationDate()
        {
            ddExpirationDate.Click();
           
            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("3");

            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("2024");

            ddDay.Click();
        }

        public void EnterVisaType()
        {
            txtVisaType.Clear();
            txtVisaType.SendKeys("Visiting Visa");
        }

        public void EnterVisaYear()
        {
            txtVisaYear.Clear();
            txtVisaYear.SendKeys("2014");
        }

        public void HitAgencyTab()
        {
            btnAgencyTab.Click();
        }

        public void SelectAgencyName()
        {
            iWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.mat-select-placeholder")));
            ddAgencyName.Click();
            ddSelectAgencyName[2].Click();
        }


        public void EnterAgentName()
        {
            txtAgentName.Clear();
            txtAgentName.SendKeys("James Bond");
        }

        public void EnterAgentMobileNumber()
        {
            txtAgentMobileNumber.Clear();
            txtAgentMobileNumber.SendKeys("9876543210");
        }

        public void EnterAgentEmailId()
        {
            txtAgentEmailId.Clear();
            txtAgentEmailId.SendKeys("abc@gmail.com");
        }


        public void EnterAgencyStartDate()
        {
            ddAgencyStartDate.Click();

            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("3");

            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("1992");

            ddDay.Click();

        }

        public void EnterAgencyEndDate()
        {
            ddAgencyEndDate.Click();

            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("3");

            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("2018");

            ddDay.Click();
        }

        public void HitBudgetTab()
        {
            btnBudgetTab.Click();
        }

        public void EnterMinimumCompensation()
        {
            txtMinimumCompensation.Clear();
            txtMinimumCompensation.SendKeys("1000");
        }

        public void EnterMaximumCompensation()
        {
            txtMaximumCompensation.Clear();
            txtMaximumCompensation.SendKeys("100000");
        }

        public void HitSecurityQuestionTab()
        {
            btnSecurityQuestionTab.Click();
        }

        public void EnterChildhoodName()
        {
            txtEnterChildhoodName.Clear();
            txtEnterChildhoodName.SendKeys("Chintu");
        }

        public void EnterChildhoodFriend()
        {
            txtEnterChildhoodFriend.Clear();
            txtEnterChildhoodFriend.SendKeys("Rohit");
        }

        public void EnterFavouriteTeam()
        {
            txtEnterFavouriteTeam.Clear();
            txtEnterFavouriteTeam.SendKeys("India");
         }
        public void HitAboutMeTab()
        {
            btnAboutMeTab.Click();
        }

        public void EnterAboutMe()
        {
            txtAboutMe.Clear();
            txtAboutMe.SendKeys("Myself Rajani Tyagi, live in Ghaziabad in the New Panchwati colony. I read in the class 5th in the section B. I read in the school New Era Ghaziabad. I am very punctual and like to do my all works throughout the day at right time. I love to eat simple and healthy food. I like dancing, reading books, playing badminton and cooking in my spare time. I never bunk my classes and attend every class. I go to school daily in proper uniform. I do well in the exams whether main or class tests. I have many friends however Sarita is my best friend.");
        }

        public void SelectSkip()
        {
            btnSkip.Click();
        }

        public void VerifyCompletedProfilePage()
        {
            Thread.Sleep(3000);
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.profile-view-dash.login-success.onboarding-success-box")));
            Thread.Sleep(2000);
            string profileCompletion = driver.FindElement(By.CssSelector(" div.profile-view-dash.login-success.onboarding-success-box > h4")).Text;
            Assert.AreEqual("Thank you for completing your profile. Your profile is 100 % complete.", profileCompletion);
        }

        public void HitOnViewDashboard()
        {
            btnViewDashboard.Click();
        }

        public void VerifyTheTalentDashboardPage()
        {
            Assert.AreEqual(true, driver.FindElement(By.CssSelector("[routerlink = '/jobs/applied']")).Enabled);

        }

    }
}
