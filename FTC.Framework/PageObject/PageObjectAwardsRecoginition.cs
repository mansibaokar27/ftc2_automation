using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FTC.Framework.PageObject
{
   public class PageObjectAwardsRecoginition
    {
        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;

        public PageObjectAwardsRecoginition(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector,Using ="[title|='Awards and Recognitions']" )]
        private IWebElement titleAwardsRecognition;

        [FindsBy(How = How.CssSelector, Using = "[title|='Delete']")]
        private IWebElement btnDeleteAward;

        [FindsBy(How = How.ClassName, Using = "project-title-box")]
        private IWebElement titlebarAwards;

        [FindsBy(How = How.CssSelector, Using = "div.col-md-2.col-sm-19.col-xs-12.text-right > div > a")]
        private IWebElement btnAddAwards;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='*Award Title']")]
        private IWebElement tbAwardTitle;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='*Award For']")]
        private IWebElement tbAwardFor;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='*Award Year']")]
        private IWebElement tbAwardYear;

        [FindsBy(How = How.CssSelector, Using = "div#step7 button[type='submit']:nth-child(3)")]
        private IWebElement btnNext;


        public void ClickAwardsRecognitionTab()
        {
            titleAwardsRecognition.Click();
        }   

        public void DeleteAllAwards()
        {
            int count = driver.FindElements(By.CssSelector("div.project-title-box > span")).Count(); //This to get the number of spans
           
            for (int i = count; i >= 1; i--)
            {
                btnDeleteAward.Click();
            }

         }

        public void AddAnAward()
        {
            btnAddAwards.Click();

        }

        public void AddAwardTitle(string value1, string value2, string value3)
        {
            tbAwardTitle.Click();
            tbAwardTitle.SendKeys(value1);
            tbAwardFor.Click();
               tbAwardFor.SendKeys(value2);
               tbAwardYear.Click();
               tbAwardYear.SendKeys(value3);
                btnNext.Click();
        }

        public void verifyAwardpage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("mat-select-value-text")));
            Thread.Sleep(2000);
            string award = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Awards and Recognitions", award);
        }
        //public static     
        //    tbAwardFor.Click();
        //    tbAwardFor.SendKeys("Best Actor");
        //    tbAwardYear.Click();
        //    tbAwardYear.SendKeys("2012");
        //    btnNext.Click();
        //}

    }
}
