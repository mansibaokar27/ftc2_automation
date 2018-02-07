using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    public class PageObject_Education
    {

        private IWebDriver driver;
        private IWait<OpenQA.Selenium.IWebDriver> iWait;


        public PageObject_Education(IWebDriver driver,IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "div.wizard-inner > ul > li:nth-child(8) > a > span")]
        public IWebElement btnEducationTab { get; set; }


        [FindsBy(How = How.CssSelector, Using = "[title|='Delete']")]
        public IWebElement btnDeleteEducation; //This for deleting your respective span

        [FindsBy(How = How.CssSelector, Using = "div.col-md-2.col-sm-19.col-xs-12.text-right > div > a")]
        public IWebElement btnAddEducation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='*School / Company']")]
        public IWebElement txtSchool { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='Other School / Company']")]
        public IWebElement txtSelectOtherSchool { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder|='*Course Completed']")]
        public IWebElement txtCourse { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='year']")]
        public IWebElement txtCourseCompletionYear { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='city']")]
        public IWebElement txtCourseCompletedFromCity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname='country']")]
        public IWebElement txtCourseCompletedFromCountry{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#step8 button[type='submit']:nth-child(3)")]
        public IWebElement btnNext { get; set; }

        public void HitEductationTab()
        {
            btnEducationTab.Click();

        }
        public void VerifyEducationPage()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[role='tabpanel']")));
            Thread.Sleep(2000);
            string education = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Education", education);
        }

        public void DeleteAllEducation()
        {
            int count = driver.FindElements(By.CssSelector("div.project-title-box > span")).Count(); //This to get the number of spans

            for (int i = count; i >= 1; i--)
            {
                btnDeleteEducation.Click();
            }
        }
        public void AddEducation()
        {
            btnAddEducation.Click();

        }
        public void SelectSchool()
        {
            txtSchool.SendKeys("Others");
            txtSchool.SendKeys(Keys.Tab);
            txtSelectOtherSchool.SendKeys("abc Production Company");
         }

        public void EnterCourseCompleted()
        {
            txtCourse.SendKeys("M.Tech");
        }

        public void EnterCourseCompletionYear()
        {
            txtCourseCompletionYear.SendKeys("2016");
        }

        public void EnterCourseCompletedFromCity()
        {
            txtCourseCompletedFromCity.SendKeys("Mumbai");
        }

        public void EnterCourseCompletedFromCountry()
        {
            txtCourseCompletedFromCountry.SendKeys("India");
        }

    }
}
