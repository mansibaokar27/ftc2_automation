using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace FTC.Framework.PageObject
{
    public class PageObjectSkills
    {
        private IWebDriver driver;
        private IWait<IWebDriver> iWait;

        public PageObjectSkills(IWebDriver driver, IWait<IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div#step4 div:nth-child(1) > div > div > angular2-multiselect > div > div.selected-list > button[type='button']")]
        public IWebElement ddPerformerSkills;

        [FindsBy(How = How.CssSelector, Using = "div#step4 div:nth-child(2) > div > div > angular2-multiselect > div > div.selected-list > button[type='button']")]
        public IWebElement ddLanguagesSpoken;

        [FindsBy(How = How.CssSelector, Using = "[title|='Skills']")]
        public IWebElement titleSkills;

        public void ClickSkillsTab()
        {
            titleSkills.Click();
        }

        public void SelectPerformerSkills()
        {
            driver.FindElements(By.ClassName("c-btn"))[0].Click();
           // ddPerformerSkills.Click();
            driver.FindElements(By.ClassName("list-area"))[0].FindElements(By.CssSelector("ul > li"))[2].Click();
        }

        public void SelectLanguagesSpoke()
        {
            driver.FindElements(By.ClassName("c-btn"))[1].Click();
            driver.FindElements(By.ClassName("list-area"))[1].FindElements(By.CssSelector("ul > li"))[2].Click();

          //  ddLanguagesSpoken.Click();
        }

        public void ValidateSkills()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[role='tabpanel']")));
            Thread.Sleep(3000);
            String Title = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Skills", Title);
        }

    }
}



