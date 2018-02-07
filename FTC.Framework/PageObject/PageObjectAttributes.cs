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
    public class PageObjectAttributes
    {
        private IWebDriver driver;
        private IWait<IWebDriver> iWait;

        public PageObjectAttributes(IWebDriver driver, IWait<IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='weightSizeId']")]
        private IWebElement ddWeight;

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='heightId']")]
        public IWebElement ddHeight;

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='chestSizeId']")]
        public IWebElement ddChest;

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='waistId']")]
        public IWebElement ddWaist;
              
        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='bodyTypeId']")]
        public IWebElement ddBodyType;

        //[FindsBy(How = How.CssSelector, Using = "[formcontrolname|='ethnicity']")]
        //public IWebElement ddEthnicity;

        [FindsBy(How = How.CssSelector, Using = "[title|='Attributes']")]
        public IWebElement titleAttributes;

        public void ClickAttributesTab()
        {
            titleAttributes.Click();
        }

        public void SelectWeight()
        {
            ddWeight.Click();
            Thread.Sleep(2000);
            driver.FindElements(By.ClassName("mat-option"))[1].Click();
        }

        public void SelectHeight()
        {
            ddHeight.Click();
            Thread.Sleep(2000);
            //SelectElement height = new SelectElement(ddHeight);
            //height.SelectByIndex(2);
            driver.FindElements(By.ClassName("mat-option"))[1].Click();
        }
        public void SelectChest()
        {
            ddChest.Click();
            Thread.Sleep(2000);
            //SelectElement chest = new SelectElement(ddChest);
            //chest.SelectByIndex(0);
            driver.FindElements(By.ClassName("mat-option"))[1].Click();
        }

        public void SelectWaist()
        {
            //Thread.Sleep(2000);
            ddWaist.Click();
            Thread.Sleep(2000);
            //SelectElement waist = new SelectElement(ddWaist);
            //waist.SelectByIndex(1);
            driver.FindElements(By.ClassName("mat-option"))[1].Click();
        }

        public void SelectBodyType()
        {
            ddBodyType.Click();
            Thread.Sleep(2000);
            //SelectElement bodytype = new SelectElement(ddBodyType);
            //bodytype.SelectByIndex(2);
            driver.FindElements(By.ClassName("mat-option"))[1].Click();
        }

        public void SelectEthnicity()
        {
             driver.FindElements(By.ClassName("c-btn"))[0].Click();
             driver.FindElements(By.ClassName("list-area"))[0].FindElements(By.CssSelector("ul > li"))[2].Click();
        }

        public void ValidateAttributes()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[role='tabpanel']")));
            Thread.Sleep(3000);
            String Title = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Attributes", Title);
        }
    }
}
