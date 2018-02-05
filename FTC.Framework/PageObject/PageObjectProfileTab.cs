using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace FTC.Framework.PageObject
{
    public class PageObjectProfileTab
    {
        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;

        public PageObjectProfileTab(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
        }
        #region Elements 

        By CompanyName = By.CssSelector("input[placeholder='*Company/Official Name']");

        By RecruiterName = By.CssSelector("input[placeholder='Name']");

        By email = By.CssSelector("input[placeholder='Email']");

        By nextBtn = By.CssSelector("ul.list-inline.btn-onboarding >li");
        #endregion

        public void enterCompanyName()
        {
            driver.FindElement(CompanyName).Clear();
            Random ran = new Random();
            int temp0 = ran.Next(0, 1000);
            string Companyname = "Marvel" + temp0;
            driver.FindElement(CompanyName).SendKeys(Companyname);

        }

        public void enterRecruiterName()
        {          
            Random ran = new Random();
            int temp1 = ran.Next(0, 1000);
            string Name = "Abc"+ temp1;
            driver.FindElement(RecruiterName).Clear();
            driver.FindElement(RecruiterName).SendKeys(Name);
        }

        public void enterEmailId()
        {           
            Random ran = new Random();
            int temp = ran.Next(0, 1000);
            string Name = "Abc" + temp+"@yopmail.com";
            driver.FindElement(email).Clear();
            driver.FindElement(email).SendKeys(Name);
        }

        public void clickOnNext()
        {
            Thread.Sleep(2000);
            iWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.btn.onboarding-step.onbaording-top-nav.text-right")));
            driver.FindElement(By.CssSelector("button.btn.onboarding-step.onbaording-top-nav.text-right")).Click();
            //int count = driver.FindElements(nextBtn).Count;
          //  driver.FindElements(nextBtn)[1].Submit();
           // w.Click();
        }

        public void verifyprofilepage()
        {
            string profile = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Profile",profile);
        }
    }
}
