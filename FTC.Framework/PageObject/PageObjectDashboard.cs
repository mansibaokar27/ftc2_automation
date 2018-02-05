using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FTC.Framework.PageObject
{
   public class PageObjectDashboard
    {
        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;

        public PageObjectDashboard(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
        }

        #region Elements

        By profile = By.CssSelector("button.border-none.mat-button");

        By editProfile = By.CssSelector("span[class='marginR-15 cursor-pointer'][title='Edit Profile']");
        #endregion
        public void selectProfile()
        {
            driver.FindElement(profile).Click();
            driver.FindElements(By.CssSelector("div.mat-menu-ripple.mat-ripple"))[0].Click();
            //Random ran = new Random();
            //int temp = ran.Next(0, 1000);
            //string name = "Marvel" + temp;
            //driver.SwitchTo().Frame("ssIFrame_google");

           // driver.SwitchTo().DefaultContent();
        }

        public void verifylogin()
        {
            Assert.AreEqual( true, driver.FindElement(By.LinkText("Dashboard")).Enabled);
        }

        public void clickonEditProfile()
        {
            driver.FindElement(editProfile).Click();
        }

    }
}
