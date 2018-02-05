using System;
using FTC.Framework.Configuration;
using FTC.Framework.Utils;

namespace FTC.Framework.Utils
{
    public class Driver
    {
        Config config = new Config();

        public static BrowserInit browser { get; set; }
     
        public static void Intitialize()
        {
            browser = new BrowserInit();
            TurnOnWait();
            browser.driver.Manage().Window.Maximize();
        }

        public static void Navigate(String homeURL)
        {
            browser.GoToUrl(homeURL);
        }

        public static void Close()
        {
            if(browser.driver != null)
            browser.driver.Quit();
        }

        private static void TurnOnWait()
        {
            browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }
    }
}
