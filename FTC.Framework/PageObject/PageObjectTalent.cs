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

    public class PageObjectTalent
    {
        private IWebDriver driver;
        private IWait<IWebDriver> iWait;

        public PageObjectTalent(IWebDriver driver, IWait<IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[title|='Talent']")]
        private IWebElement titleTalent;

        public void ClickTalentTab()
        {
            titleTalent.Click();
        }

       
        public void SelectTalent()
        {
            driver.FindElement(By.ClassName("edit-category-option")).FindElements(By.TagName("li"))[5].FindElements(By.TagName("span"))[1].Click();
        }

        public void ValidateTalent()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[role='tabpanel']")));
            Thread.Sleep(3000);
            String Title = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Talent", Title);
        }
    }
}

