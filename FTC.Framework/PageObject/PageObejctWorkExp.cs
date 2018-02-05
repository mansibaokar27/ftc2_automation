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
    public class PageObjectWorkExp
    {
        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;

        public PageObjectWorkExp(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[title|='Work Experience']")]
        private IWebElement titleWorkExperience;

        [FindsBy(How = How.CssSelector, Using = "[title|='Delete']")]
        private IWebElement btnDeleteWorks;

        [FindsBy(How = How.ClassName, Using = "project-title-box")]
        private IWebElement titlebarWorks;

        [FindsBy(How = How.CssSelector, Using = "div.col-md-2.col-sm-19.col-xs-12.text-right > div > a")]
        private IWebElement btnAddWorks;

       [FindsBy(How = How.ClassName, Using = "mat-select-trigger")]
        private IWebElement ddProjectType;

       [FindsBy(How = How.CssSelector, Using = "[placeholder|='*Production Name']")]
       private IWebElement tbProductionName;

       [FindsBy(How = How.CssSelector, Using = "[placeholder|='*Project Title']")]
       private IWebElement tbProjectTitle;

       [FindsBy(How = How.CssSelector, Using = "[placeholder|='*Year']")]
       private IWebElement tbYear;
       
        public void ClickWorkExTab()
        {
            titleWorkExperience.Click();
        }

        public void DeleteAllWorks()
        {
            int count = driver.FindElements(By.CssSelector("div.project-title-box > span")).Count(); 

            for (int i = count; i >= 1; i--)
            {
                btnDeleteWorks.Click();
            }
        }
        public void AddWorks()
        {
            btnAddWorks.Click();

        }
        public void AddPtypedropdown()
        {
            ddProjectType.Click();
            Thread.Sleep(2000);
            driver.FindElements(By.ClassName("mat-option"))[2].Click();
            //ddProjectType.Click();
            //SelectElement ProjectType = new SelectElement(ddProjectType);
            //ProjectType.SelectByText("Radio");
        }
        public void addtitle()
        {
            tbProjectTitle.Click();
            tbProjectTitle.SendKeys("Rings");
        }
         public void addYear()
        {
            tbYear.Click();
            tbYear.SendKeys("2012");
        }
        public void addPname()
        {
            tbProductionName.Click();
            tbProductionName.SendKeys("Project title");
        }

        public void verifyWorkExppage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("mat-select-value-text")));
            Thread.Sleep(2000);
            string WorkExp = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Work Experience", WorkExp);
        }
    }
    }

