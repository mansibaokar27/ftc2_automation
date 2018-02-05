using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
namespace FTC.Framework.PageObject
{
    public class PageObject_SecurityQuestions
    {

        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;
        private readonly object clickLogin;

        public PageObject_SecurityQuestions(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {

            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);



        }


        //[FindsBy(How = How.CssSelector, Using = " div.wizard-inner > ul > li:nth-child(6) > a > span")]
        //public IWebElement btnSecurityQuestionsTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Your childhood nickname?']")]
        public IWebElement txtEnterChildhoodName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Your favourite childhood friend?']")]
        public IWebElement txtEnterChildhoodFriend { get; set; }
       
        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Your favourite team?']")]
        public IWebElement txtEnterFavouriteTeam { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input[placeholder]='Your favourite movie?']")]
         public IWebElement txtEnterFavouriteMovie { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder]='Your First job?']")]
        public IWebElement txtEnterFirstJob { get; set; }


      


        public void EnterChildhoodName(string value)
        {

            iWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[placeholder|='Your childhood nickname?']")));
            txtEnterChildhoodName.Clear();
            txtEnterChildhoodName.SendKeys(value);

        }

        public void EnterChildhoodFriend(string value)
        {
            // wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[placeholder|='Your favourite childhood friend ?']")));
            txtEnterChildhoodFriend.Clear();
            txtEnterChildhoodFriend.SendKeys(value);
        }

        public void EnterFavouriteTeam(string value)
        {

            //  wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(" input[placeholder|='Your favourite team ? ']")));
            
            txtEnterFavouriteTeam.Clear();
            txtEnterFavouriteTeam.SendKeys(value);

        }

        public void EnterFavouriteMovie(string value)
        {

           // txtEnterFavouriteMovie.Click();
            txtEnterFavouriteMovie.Clear();
            txtEnterFavouriteMovie.SendKeys(value);
        }

        public void EnterFirstJob(string value)
        { 
                   
            txtEnterFirstJob.Clear();
            txtEnterFirstJob.SendKeys(value);




        }
        public void verifysecuritypage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("mat-select-value-text")));
            Thread.Sleep(2000);
            string security = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Security Questions", security);
        }
    }
}
