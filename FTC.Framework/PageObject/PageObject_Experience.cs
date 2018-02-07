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
    public class PageObject_Experience
    {

        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;
      

        public PageObject_Experience(IWebDriver driver,IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = " div.wizard-inner > ul > li:nth-child(7) > a > span")]
        public IWebElement btnExperienceTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[title|='Delete']")]
        public IWebElement btnDeleteExperiences; //This for deleting your respective span

        [FindsBy(How = How.CssSelector, Using = "div.col-md-2.col-sm-19.col-xs-12.text-right > div > a")]
        public IWebElement btnAddExperience { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(1) > md-select > div > span.mat-select-placeholder")]
        public IWebElement ddInterestType { get; set; }

        [FindsBy(How = How.ClassName, Using = "mat-option")]
        public IList<IWebElement> ddSelectInterestType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(2) > md-select > div > span.mat-select-placeholder")]
        public  IWebElement ddSkillType { get; set; }

        [FindsBy(How = How.ClassName, Using = "mat-option")]
        public IList<IWebElement>  ddSelectSkillType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='*Production House']")]
        public IWebElement txtProductionHouse { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[formcontrolname='productionHouse']")]
        public IWebElement txtOtherProductionHouse { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='*Project Title']")]
        public IWebElement txtProjectTitle { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='*Role in Project']")]
        public IWebElement txtProjectRole { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[formcontrolname='year']")]
        public IWebElement txtProjectYear { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#step7 button[type='submit']:nth-child(3)")]
        public IWebElement btnNext { get; set; }



        public void SelectExperienceTab()
        {
            btnExperienceTab.Click();
        }

        public void VerifyExperiencePage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[role='tabpanel']")));
            Thread.Sleep(2000);
            string experience = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Experience", experience);
        }

        public void DeleteAllExperiences()
        {
            int count = driver.FindElements(By.CssSelector("div.project-title-box > span")).Count(); //This to get the number of spans

            for (int i = count; i >= 1; i--)
            {
                btnDeleteExperiences.Click();
            }
        }


        public void AddExperience()
        {
            btnAddExperience.Click();
        }

        public void SelectInterestType()
        {
            ddInterestType.Click();
            ddSelectInterestType[2].Click();
        }

        public void SelectSkillType()
        {
            ddSkillType.Click();
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#cdk-overlay-1 > div > div")));
            ddSelectSkillType[3].Click();
        }

        public void SelectProductionHouse()
        {
            txtProductionHouse.SendKeys("Others");
            txtProductionHouse.SendKeys(Keys.Tab);
            txtOtherProductionHouse.SendKeys("Meghna Production");


        }

        public void EnterProjectTitle()
        {
            txtProjectTitle.SendKeys("Hello");
        }

        public void EnterProjectRole()
        {
            txtProjectRole.SendKeys("Lead");
        }

        public void EnterProjectYear()
        {
            txtProjectYear.SendKeys("2018");

        }
    }
}
