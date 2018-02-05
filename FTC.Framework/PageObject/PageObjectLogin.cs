using FTC.Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FTC.Framework.PageObject
{
    public class PageObjectLogin
    {
        private IWebDriver driver;
		private IWait<OpenQA.Selenium.IWebDriver> iWait;

        public PageObjectLogin(IWebDriver driver, IWait<OpenQA.Selenium.IWebDriver> iWait)
        {
            this.driver = driver;
            this.iWait = iWait;
        }


        #region Elements 

        By txtUsername = By.CssSelector("input[formcontrolname = 'userId']");
        By txtPassword = By.CssSelector("input[formcontrolname='password']");
      //  By btnLogin = By.CssSelector("btn btn-danger dashboard-btn waves-effect waves-light");
        By btnLogin = By.CssSelector("div.login-btn-grp > input");
        //
        #endregion

    
        public void EnterUsername(String username)
        {
            driver.FindElement(txtUsername).SendKeys(username);
        }

        public void EnterPassword(String password)
        {
            driver.FindElement(txtPassword).SendKeys(password);
        }

        public void ClickLogin()
        {
            IWebElement w = driver.FindElement(btnLogin);
            w.Click();
       }
    }
}
