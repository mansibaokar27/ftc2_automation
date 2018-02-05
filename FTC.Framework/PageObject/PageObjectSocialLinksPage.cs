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
    public class SocialLinksPage
    {
        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;

        public SocialLinksPage(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[title|='Social Links']")]
        private IWebElement titleSocialLinks;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='Facebook']")]
        private IWebElement tbFaceBook;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='Twitter']")]
        private IWebElement tbTwitter;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='Instagram']")]
        private IWebElement tbInstagram;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='Youtube']")]
        private IWebElement tbYouTube;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='Website Link']")]
        private IWebElement tbWebsiteLink;

        [FindsBy(How = How.CssSelector, Using = "[placeholder|='IMDB']")]
        private IWebElement tbIMDB;


        public void ClickSocialLinksTab()
        {
            titleSocialLinks.Click();
        }

        public void EnterFbDetails()
        {
            tbFaceBook.Click();
            tbFaceBook.Clear();
            tbFaceBook.SendKeys("www.fb.com");
        }

        public void EnterTwitterDetails()
        {
            tbTwitter.Click();
            tbTwitter.Clear();
            tbTwitter.SendKeys("www.twitter.com");
        }

        public void EnterInstagramDetails()
        {
            tbInstagram.Click();
            tbInstagram.Clear();
            tbInstagram.SendKeys("www.instagram.com");
        }

        public void EnterYouTubeDetails()
        {
            tbYouTube.Click();
            tbYouTube.Clear();
            tbYouTube.SendKeys("www.youtube.com");
        }

        public void EnterPersonalWebsiteDetails()
        {
            tbWebsiteLink.Click();
            tbWebsiteLink.Clear();
            tbWebsiteLink.SendKeys("www.mywebsite.com");
        }

        public void EnterIMDBDetails()
        {
            tbIMDB.Click();
            tbIMDB.Clear();
            tbIMDB.SendKeys("www.imdb.com");
        }
        public void verifysocialpage()
        {
           // iWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("mat-select-value-text")));
            Thread.Sleep(2000);
            string social = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Social Links", social);
        }

    }
}
