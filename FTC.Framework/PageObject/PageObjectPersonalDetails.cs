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
   public class PageObjectPersonalDetails
    {

        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;


        public PageObjectPersonalDetails(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = " sd-signup-success > div > div > div > div > form > div > button")]
        public IWebElement btnCompleteProfile { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.wizard-inner > ul > li:nth-child(1) > a > span")]
        public IWebElement btnPersonalDetailsTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder |= '*Full Name']")]
        public IWebElement txtEnterName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(2) > div > div > div.angular-date-box > img")]
        public IWebElement ddDateOfBirth { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-navigation-select > select:nth-child(1)")]
        public IWebElement ddMonth;
       
        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-navigation-select > select:nth-child(2)")]
        public IWebElement ddYear;

        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-month-view > div:nth-child(4) > div:nth-child(3) > div")]
        public IWebElement ddDay;

        [FindsBy(How = How.CssSelector, Using = "input[placeholder |= '*Search Cities']")]
        public IWebElement txtEnterCity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder |= 'Zipcode']")]
        public IWebElement txtEnterZipcode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#step1 > form > ul > li > button")]
        public IWebElement btnNext{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder |= '*Name Of Guardian']")]
        public IWebElement txtNameOfGuardian { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder |= '*Relation With Talent']")]
        public IWebElement txtRelationwithGuardian { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder |= '*Guardian Mobile No.']")]
        public IWebElement txtMobileNumberOfGuardian { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder |= 'Guardian Email ID']")]
        public IWebElement txtGuardianEmailID { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[title='Next']")]
        public IWebElement btnSelectNext { get; set; }



        public void HitCompleteProfileTab()
        {
            btnCompleteProfile.Click();
        }

        public void verifylogin()
        {
            Assert.AreEqual(true, driver.FindElement(By.CssSelector("sd-signup-success > div > div > div > div > form > div > button")).Enabled);
        }

        public void VerifyPersonalDetailsPage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[role='tabpanel']")));
            Thread.Sleep(2000);
            string personalDetails = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Contact Details", personalDetails);
        }
        public void HitPersonalDetailsTab()
        {
            btnPersonalDetailsTab.Click();
        }

        public void EnterName()
        {
            txtEnterName.Clear();
            Random ra = new Random();
            int random = ra.Next(0, 10000);
             string newName = "sonakshi sinha" + random;
            txtEnterName.SendKeys(newName);
        }

        public void EnterDateOfBirthLessThan18()
        {
            ddDateOfBirth.Click();

            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("3");

            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("2004");

            ddDay.Click();
        }

        public void EnterDateOfBirthGreaterThan18()
        {
            ddDateOfBirth.Click();

            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("3");

            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("1992");

            ddDay.Click();
        }

        public void EnterCity()
        {
            txtEnterCity.Clear();
            txtEnterCity.SendKeys("Mumbai, MH, India");
            Thread.Sleep(2000);
           // iWait.Until(ExpectedConditions.ElementToBeClickable(By.TagName("ng2-auto-complete")));
            txtEnterCity.SendKeys(Keys.Enter);
        }

        public void EnterNameOfGuardian()
        {
            iWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[placeholder |= '*Name Of Guardian']")));
            txtNameOfGuardian.Clear();
            txtNameOfGuardian.SendKeys("Shatrughan");
        }

        public void EnterRelationWithGuardian()
        {
            txtRelationwithGuardian.Clear();
            txtRelationwithGuardian.SendKeys("Father");
        }


        public void EnterMobileNumberOfGuardian()
        {
            txtMobileNumberOfGuardian.Clear();
            txtMobileNumberOfGuardian.SendKeys("9876543210");
        }

        public void EnterGuardianEmailID()
        {
            txtGuardianEmailID.Clear();
            txtGuardianEmailID.SendKeys("abc@gmail.com");
        }

        public void SelectNextButton()
        {
            btnSelectNext.Submit();
        }

    
    }
}
