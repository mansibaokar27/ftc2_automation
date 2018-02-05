using FTC.Framework.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using FTC.Framework.Utils;
//using FTC.Framework.Web_Pages;
//using FTC.Framework.PageObject.Report;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace FTC.Framework.Utils
{
    public class Objects
    {
        IWebDriver driver = null;
        IWait<IWebDriver> iWait= null;

        public Objects(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
        }
     
        public static Configuration.Config objConfig { get; set; }


        // public static Page_Object_SelectionQA_Config poSelectionQaConfig { get; set; }

        public static PageObjectLogin poLogin { get; set; }

        public static PageObjectDashboard poDashboard { get; set; }

        public static PageObjectProfileTab poProfileTab { get; set; }

        public static PageObjectWorkExp poWorkExpTab { get; set; }

        public static PageObjectAwardsRecoginition poAwardRecog { get; set; }

        public static SocialLinksPage poSociallinks { get; set; }

        public static PageObject_Association poassosication { get; set; }

        public static PageObject_SecurityQuestions posecurityquestions { get; set; }

        public void ObjectInitialization()
        {

            Logger.log.Info("Object Initialization is started.");

            objConfig = new Configuration.Config();

            poLogin = new PageObjectLogin(driver, iWait);

            poDashboard = new PageObjectDashboard(driver, iWait);

            poProfileTab = new PageObjectProfileTab(driver, iWait);

            poWorkExpTab = new PageObjectWorkExp(driver, iWait);

            poAwardRecog = new PageObjectAwardsRecoginition(driver, iWait);

            poSociallinks = new SocialLinksPage(driver, iWait);

            poassosication = new PageObject_Association(driver, iWait);

            posecurityquestions = new PageObject_SecurityQuestions(driver, iWait);
            // poSelectionQaConfig = new Page_Object_SelectionQA_Config(driver, iWait);

            Logger.log.Info("Object Initialization is completed.");

        }

    }
}


