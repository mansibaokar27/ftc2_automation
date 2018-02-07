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
    public class PageObjectMedia
    {
        private IWebDriver driver;
        private IWait<IWebDriver> iWait;

        public PageObjectMedia(IWebDriver driver, IWait<IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[title|='Media']")]
        public IWebElement titleMedia;

        [FindsBy(How = How.CssSelector, Using = "[title|='Remove']")]
        public IWebElement btnDeleteImages;

        [FindsBy(How = How.LinkText, Using = "Video")]
        public IWebElement tabVideo;

        [FindsBy(How = How.CssSelector, Using = "[formcontrolname|='externalURL']")]
        public IWebElement tbYoutubeLink;

        [FindsBy(How = How.Name, Using = "file-upload")]
        public IWebElement UploadVideo;

        [FindsBy(How = How.LinkText, Using = "Script")]
        public IWebElement tabScript;

        [FindsBy(How = How.Name, Using = "file-upload")]
        public IWebElement btnUploadScript;

        [FindsBy(How = How.LinkText, Using = "Audio")]
        public IWebElement tabAudio;

        [FindsBy(How = How.Name, Using = "file-upload")]
        public IWebElement btnUploadAudio;

        public void ClickMediaTab()
        {
            titleMedia.Click();
        }

        //[FindsBy(How = How.CssSelector, Using = "for| = '7'")]
        //private IWebElement boxPicture;

        public void UploadPic()
        {
           //int cc = driver.FindElements(By.LinkText("Video")).Count();

           //int cb =  driver.FindElements(By.CssSelector("div.col-md-3.col-sm-6.col-xs-12"))[0].FindElements(By.CssSelector("div.onboarding-media-file > div.file-upload > input")).Count();
            Thread.Sleep(2000);
            driver.FindElements(By.CssSelector("div.col-md-3.col-sm-6.col-xs-12"))[0].FindElement(By.CssSelector("div.onboarding-media-file > div.file-upload > input")).SendKeys(@"C:\Users\swati.tiwari\Desktop\alia-.jpg");
            Thread.Sleep(2000);
            driver.FindElements(By.CssSelector("div.col-md-3.col-sm-6.col-xs-12"))[1].FindElement(By.CssSelector("div.onboarding-media-file > div.file-upload > input")).SendKeys(@"C:\Users\swati.tiwari\Desktop\alia2015.jpg");
        }

        public void SwitchToVideoTab()
        {
            Thread.Sleep(2000);
            tabVideo.Click();
        }

        public void UploadVid()
        {
            tbYoutubeLink.Clear();
            UploadVideo.SendKeys(@"D:\FTCShare\ftc_rohit\Video samples\small FTC testing for UAT.mp4");
        }

        public void SwitchToScriptTab()
        {
            Thread.Sleep(2000);
            tabScript.Click();
        }

        public void UploadScript()
        {
            btnUploadScript.SendKeys(@"D:\FTCShare\ftc_rohit\scripts samples\Tata-Sky-UserJourney-1.0.pdf");
        }

        public void SwitchToAudioTab()
        {
            Thread.Sleep(2000);
            tabAudio.Click();
        }

        public void UploadAudio()
        {
            btnUploadScript.SendKeys(@"D:\FTCShare\ftc_rohit\Audio samples\SampleAudio_2.7mb.mp3");
        }

        public void ValidateMedia()
        {
            iWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[role='tabpanel']")));
            Thread.Sleep(3000);
            String Title = driver.FindElement(By.ClassName("edit-profile-title")).Text;
            Assert.AreEqual("Media", Title);
        }

    }
}
