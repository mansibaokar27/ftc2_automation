using System;
using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Safari;
using System.IO;
using System.Xml;
using System.Configuration;
using FTC.Framework.Broswer;
using FTC.Framework.Enum;
using Microsoft.Win32;
using FTC.Framework.Common;
using System.Drawing;
using OpenQA.Selenium.Remote;

namespace FTC.Framework.Utils
{
    public class BrowserInit
    {

        

        public IWebDriver driver;
        internal string driverName = string.Empty;
        internal string driverPath = string.Empty;
        public IWait<IWebDriver> iWait = null;
        public  DesiredCapabilities dCaps;
        Browsers browser = new Browsers();
        Helper helper = new Helper();
        
        int screenHeight, screenWidth;

        public BrowserInit()
        {

            try
            {
                string rootPath = AppDomain.CurrentDomain.BaseDirectory;

                //string rootPath = Environment.CurrentDirectory;

                //string rootPath = @"D:\workspace\FTC\FTC\FTC.Framework\bin\Debug";


                //System.Environment.SetEnvironmentVariable(driverName, driverPath);

                if (Convert.ToBoolean(browser.SelectBrowser(BrowserCollection.firefox.ToString(), "Browser.xml")) == true)
                {
                    driver = new FirefoxDriver();
          
                    Current.BrowserName = BrowserCollection.firefox.ToString();

                   screenHeight = Helper.GetScreenHeight(driver);

                   screenWidth = Helper.GetScreenWidth(driver);

                   Helper.SetWindowPosition(driver, 0, 0);

                   Helper.SetWindowSize(driver, screenWidth, screenHeight);
                    
                }
                else if (Convert.ToBoolean(browser.SelectBrowser(BrowserCollection.chrome.ToString(), "Browser.xml")) == true)
                {
                  

                    driverName = "webdriver.chrome.driver";

                  //  driverPath = rootPath + "\\chromedriver.exe";

                    System.Environment.SetEnvironmentVariable(driverName, driverPath);
                   // driverPath = rootPath+"\\Library\\";
                   // driverName = "webdriver.chrome.driver";

                    ChromeOptions options = new ChromeOptions();
                    //options.AddArgument("--disable-extensions");
                    driver = new ChromeDriver(rootPath, options);

                    Current.BrowserName = BrowserCollection.chrome.ToString();


                    screenHeight = Helper.GetScreenHeight(driver);

                    screenWidth = Helper.GetScreenWidth(driver);

                    Helper.SetWindowPosition(driver, 0, 0);

                    Helper.SetWindowSize(driver, screenWidth, screenHeight);

                    Console.WriteLine("Is Driver null :: " + (driver == null));
                    
                }
                else if (Convert.ToBoolean(browser.SelectBrowser(BrowserCollection.ie.ToString(), "Browser.xml")) == true)
                {
                    InternetExplorerOptions options = new InternetExplorerOptions();
                    options.EnsureCleanSession = true;
                    options.EnableNativeEvents = true;
                    options.IgnoreZoomLevel = true;
                    options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                     driverName = "webdriver.ie.driver";
                    driverPath = rootPath + "/IEDriverServer.exe";

                    driver = new InternetExplorerDriver(options);
                    screenHeight = Helper.GetScreenHeight(driver);

                    screenWidth = Helper.GetScreenWidth(driver);

                    Helper.SetWindowPosition(driver, 0, 0);

                    Helper.SetWindowSize(driver, screenWidth, screenHeight);

                    Current.BrowserName = BrowserCollection.ie.ToString();

                    // Add code to add Registry in IE 11
                    Current.IEVersion = Helper.GetIEVersion(driver, driver.FindElement(By.TagName("html")));

                    if (Current.IEVersion.Equals("IE11"))
                        Helper.CheckIE11RegistryPresence();
           
                }
                else if (Convert.ToBoolean(browser.SelectBrowser(BrowserCollection.phantom.ToString(), "Browser.xml")) == true)
                {
                   
                    driver = new PhantomJSDriver();
    
                    Current.BrowserName = BrowserCollection.phantom.ToString();

                    screenHeight = Helper.GetScreenHeight(driver);

                    screenWidth = Helper.GetScreenWidth(driver);

                    Helper.SetWindowPosition(driver, 0, 0);

                    Helper.SetWindowSize(driver, screenWidth, screenHeight);

                }
                else
                    throw new NoBrowserSelectedException();


                iWait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(150.00));

            }
            catch (NoBrowserSelectedException ex)
            {
                Logger.log.Error("Error In Browser Selection.");
                Logger.log.Error(ex);
            }
            catch (Exception ex)
            {
                Logger.log.Error("Error In Browser Initialization.");
                Logger.log.Error(ex);
            }        
        }

        internal void GoToUrl(string URL)
        {
            try
            {

                driver.Navigate().GoToUrl(URL);
                driver.Manage().Window.Maximize();
                // driver.Manage().Cookies.DeleteAllCookies();

               // iWait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(60.00));
                iWait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            }
            catch (Exception error)
            {
                Logger.log.Error("Browser could not navigate to the specified url properly");
                Logger.log.Error(error);
            }
        }
    }

    public class NoBrowserSelectedException : Exception
    {
        public override String Message
        {
             get
            {
                return "Please select any browser by setting flag in Base.Config file as true";
            }
        } 
   }

}
