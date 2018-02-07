using FTC.Framework.Utils;
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
     public class PageObjectManageProject
    {

        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;

        string projectname = null;




        public PageObjectManageProject(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[title='Manage Projects']")]
        public IWebElement btnManageProject { get; set; }


        [FindsBy(How = How.CssSelector, Using = " form > div:nth-child(1) > div:nth-child(2) > a")]
        public IWebElement btnAddProject { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[placeholder='Recruiter']")]

        public IWebElement ddSelectRecruiter { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='projectTypeId']")]

        public IWebElement ddSelectProjectType { get; set; }

        [FindsBy(How = How.CssSelector, Using = " form > div:nth-child(1) > div.row > div:nth-child(3) > div > button")]
        public IWebElement btnSelectPlanTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = " div.table-recruiter-pricing > div > table:nth-child(2) > tbody > tr:nth-child(15) > td > button")]
        public IWebElement btnSelectAnyOnePlan { get; set; }
      //  div.row.pricing-desktop > div > div.table-recruiter-pricing > div > table:nth-child(2) > tbody > tr:nth-child(15) > td > button

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='projectName']")]
         public IWebElement txtEnterProjectName { get; set; }

        [FindsBy(How = How.ClassName, Using = "mat-checkbox-input cdk-visually-hidden")]
        public IWebElement  checkboxCheckWhetherCastingRequired { get; set; }

        [FindsBy(How = How.ClassName, Using = "file-upload-input")]
        public IWebElement uploadMediaBanner { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='*Production House']")]
        public IWebElement txtProductionHouse { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[formcontrolname='otherProductionHouse']")]
        public IWebElement txtOtherProductionHouse { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Ad Agency']")]
        public IWebElement ddAdAgency { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Other TVC Agency']")]
        public IWebElement txtOtherTVCAdAgency { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Director Name']")]
        public IWebElement txtDirectorName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Producer Name']")]
        public IWebElement txtProducerName { get; set; }

        [FindsBy(How = How.CssSelector, Using = " div:nth-child(5) > div > div:nth-child(1) > div > div > div > div")]
        public IWebElement ddRecruitementStartDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-navigation-select > select:nth-child(1)")]
        public IWebElement ddMonth { get; set; }


        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-navigation-select > select:nth-child(2)")]
        public IWebElement ddYear { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ngb-datepicker-month-view > div:nth-child(4) > div:nth-child(3) > div")]
        public IWebElement ddDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(5) > div > div:nth-child(3) > div > div > div")]
        public IWebElement ddShootDate { get; set; }


        [FindsBy(How = How.CssSelector, Using = "div.col-md-4.col-sm-4.col-xs-4 > div > angular2-multiselect > div > div.selected-list > div")]
        public IWebElement btnSelectLocation { get; set; }
         

        [FindsBy(How = How.CssSelector, Using = " div.dropdown-list > div.list-area > ul > li:nth-child(2)")]
        public IWebElement chckbxSelectLocation { get; set; }



        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='description']")]
        public IWebElement txtDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = " div.col-md-12.col-sm-12.col-xs-12 > div > button")]
        public IWebElement btnSaveCreatedProject { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[placeholder='Select Recruiter']")]

        public IWebElement ddEnterTheSelectedRecriterForTheProjectCreated { get; set; }



        public void SelectManageProject()
        {
           
            btnManageProject.Click();
        }


        public void AddProject()
        { 
            
            btnAddProject.Click();

        }

        public void VerifyCreateProjectPage()
        {
            Assert.AreEqual(true, driver.FindElement(By.CssSelector("[formcontrolname|='projectTypeId']")).Enabled);
        }
        public void SelectRecruiter()
        {
            ddSelectRecruiter.Clear();
            ddSelectRecruiter.SendKeys("Amit");
            Thread.Sleep(3000);
            ddSelectRecruiter.SendKeys(Keys.Tab);

        }

        public void SelectProjectType()
        {

            ddSelectProjectType.Click();

            SelectElement projectType = new SelectElement(ddSelectProjectType);
           projectType.SelectByValue("6");
        }

        public void SelectPlan()
        {
            btnSelectPlanTab.Click();
            iWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("modal-body")));
            btnSelectAnyOnePlan.Click();
        }

        public void EnterProjectName()
        {
            Random ra = new Random();
            int random = ra.Next(0, 10000);
             projectname = "Hello" +random;
            txtEnterProjectName.SendKeys(projectname);
        }

        public void CheckWhetherCastingRequired()
        {


           IWebElement castingRequired = driver.FindElement(By.ClassName("mat-checkbox-inner-container"));

           castingRequired.Click();

            
        }

        public void SelectMediaBanner()
        {
            uploadMediaBanner.SendKeys(@"C:\Users\Public\Pictures\Sample Pictures\Hydrangeas.jpg");
        }



        public void SelectProductionHouse()
        {
            txtProductionHouse.SendKeys("Others");
            txtProductionHouse.SendKeys(Keys.Tab);
            //txtOtherProductionHouse.SendKeys("Meghna Production");


        }

        public void SelectAdAgency()
        {
            ddAdAgency.SendKeys("others");
            ddAdAgency.SendKeys(Keys.Tab);
            txtOtherTVCAdAgency.SendKeys("Kalpana Productions");
           
        }

        public void EnterDirectorName()
        {
            txtDirectorName.SendKeys("Rohit Shetty");
        }

        public void EnterProducerName()
        {
            txtProducerName.SendKeys("Gauri Khan");
        }

        public void SelectRecruitementStartDate()
        {
            ddRecruitementStartDate.Click();

            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("3");

            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("2018");

            ddDay.Click();


        }

        public void SelectShootDate()
        {
            ddShootDate.Click();

            ddMonth.Click();
            SelectElement Month = new SelectElement(ddMonth);
            Month.SelectByValue("7");

            ddYear.Click();
            SelectElement Year = new SelectElement(ddYear);
            Year.SelectByValue("2018");

            ddDay.Click();


        }

        public void SelectLocation()
        {
            btnSelectLocation.Click();

            IWebElement shootingLocation = driver.FindElement(By.CssSelector(" div.dropdown-list > div.list-area > ul > li:nth-child(2)"));

            shootingLocation.Click();
            
        }

        public void EnterTheDescriptionOfTheProject()
        {
            
            
            txtDescription.SendKeys("Work In Progress");
        }

        //public string StoreTheProjectName( )
        //{

        //    iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[formcontrolname|='projectName']")));
        //    Thread.Sleep(2000);
        //   return driver.FindElement(By.CssSelector("[formcontrolname|='projectName']")).Text;

        //}

        public void SaveCreatedProject()
        {
            btnSaveCreatedProject.Submit();
        }

      

        public void VerifyLogin()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.col-md-9.main-content.admin-manage-box")));
            Thread.Sleep(2000);
            string dashboard = driver.FindElement(By.ClassName("manage-contest-title")).Text;
            Assert.AreEqual("Dashboard", dashboard);
        }

        public void verifyManageProjectPage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("manage-contest-title")));
            Thread.Sleep(2000);
            string manageproject = driver.FindElement(By.ClassName("manage-contest-title")).Text;
            Assert.AreEqual("Manage Projects", manageproject);

            Assert.AreEqual(true, driver.FindElement(By.CssSelector("form > div:nth-child(1) > div:nth-child(2) > a")).Enabled);
        }

        public void VerifyTheCreatedProject()
        {
            Thread.Sleep(5000);
            ddEnterTheSelectedRecriterForTheProjectCreated.SendKeys("Amit");
            Thread.Sleep(3000);
            ddEnterTheSelectedRecriterForTheProjectCreated.SendKeys(Keys.Tab);
            Thread.Sleep(3000);

             string createdProjectName = driver.FindElement(By.CssSelector("div.card > div > a > span")).Text;
            Thread.Sleep(3000);
            Assert.AreEqual(projectname, createdProjectName );
         }


    }
}
