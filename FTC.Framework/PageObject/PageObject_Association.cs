using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FTC.Framework.PageObject
{
    public class PageObject_Association
    {
        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;
        private readonly object clickLogin;

        public PageObject_Association(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "div.wizard-inner > ul > li:nth-child(5) > a > span")]
        public IWebElement btnAssociationTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[title|='Delete']")]
        public IWebElement btnDeleteAssociates; //This for deleting your respective span

        [FindsBy(How = How.CssSelector, Using = "div.col-md-2.col-sm-19.col-xs-12.text-right > div > a")]
        public IWebElement btnAddAssociations { get; set; }

        [FindsBy(How = How.CssSelector, Using = " md-select > div")]
        public IWebElement ddAssociationsName { get; set; }

        [FindsBy(How = How.ClassName, Using = "mat-option")]
        public IList<IWebElement> ddSelectAssociationsName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='membershipId']")]
            
        public IWebElement txtEnterAssociationId { get; set; }

       

        [FindsBy(How = How.CssSelector, Using = "div#step7 button[type='submit']:nth-child(3)")]
        public IWebElement btnNext { get; set; }

//# step7 > form > ul > li > button:nth-child(3)
        public void SelectAssociationTab()
        {
            btnAssociationTab.Click();
        }
        public void DeleteAllAssociates()
        {

            int count = driver.FindElements(By.CssSelector("div.project-title-box > span")).Count();

            for (int i = count; i >= 1; i--)
            {
                btnDeleteAssociates.Click();
            }


            //if (driver.FindElements(By.CssSelector("div.row.ng-untouched.ng-pristine.ng-invalid")).Count() > 0)
            //{
                
            //}
          
            //else
            //{
            //   // int count = driver.FindElements(By.CssSelector("div.project-title-box > span")).Count(); //This to get the number of spans
            //    int count = driver.FindElements(By.CssSelector("div.row.ng-untouched.ng-pristine.ng-valid")).Count(); //This to get the number of spans
               
            //    if (count > 0)
            //    {
            //        for (int i = count; i >= 1; i--)
            //        {
            //            btnDeleteAssociates.Click();
            //        }
            //    }
            //}
        }


        public void AddAssociation()
        {
            btnAddAssociations.Click();
        }

        public void SelectAssociationName()
        {
            iWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.mat-select-placeholder")));
            ddAssociationsName.Click();
            ddSelectAssociationsName[2].Click();
           

        }

        public void EnterAssociationId()
        {
            txtEnterAssociationId.SendKeys("12345");
          
        }

        public void SelectNext()
        {
            btnNext.Submit();
        }

        public void verifyAssosicationExppage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("mat-select-value-text")));
            Thread.Sleep(2000);
            string assosiation = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Associations", assosiation);
        }
    }
}
