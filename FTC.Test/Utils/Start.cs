using System;
using TechTalk.SpecFlow;
using FTC.Framework.Configuration;
using NUnit.Framework;
using FTC.Framework.Utils;
using FTC.Framework.Enum;
using TechTalk.SpecFlow.Tracing;
//using NUnit.Core;
using Logger = FTC.Framework.Utils.Logger;
using System.Configuration;
using FTC.Framework.Enum;
using OpenQA.Selenium;
using System.Data.SqlClient;
using FTC.Framework.Common;
//using FTC.Framework.Steps;




namespace FTC.Framework.Utils
{
    [Binding]
    public class Start : Driver
    {

        Config config = new Config();
        Objects obj = null;

        [BeforeScenario]
        public void Setup()
        {

            #region Initialization 

            // Initiating Logger
            Logger.SetLogger();

            // Initiating Browser
            Intitialize();

            // Initializing all the Page Objects
            obj = new Objects(Driver.browser.driver, Driver.browser.iWait);
            obj.ObjectInitialization();

            // Navigating to URL
           // string s = ConfigurationManager.AppSettings["ApplicationURL"];
            Driver.Navigate("http://eac7q5systest.fthecouch.com/portal/");

            #endregion

            #region Login

            //Objects.poLogin.EnterUsername(ConfigurationManager.AppSettings["ApplicationUsername"].Trim());
            //Objects.poLogin.EnterPassword(ConfigurationManager.AppSettings["ApplicationPassword"].Trim());
            //Driver.browser.driver.FindElement(By.ClassName("panel-heading")).Click();
            //Objects.poLogin.ClickLogin();

            #endregion

            // Writing Currently executing Scenario
            Logger.log.Info("**** Scenario " + ScenarioContext.Current.ScenarioInfo.Title + " **** started.");
            Console.WriteLine("\n\n**** Scenario " + ScenarioContext.Current.ScenarioInfo.Title + " **** started.");


        }

        [AfterScenario]
        public void TearDown()
        {
            // Closing the browser
            Close();

            #region Removing all the Item added in the Scenario Context

            #endregion

            if (ScenarioContext.Current.TestError != null)
            {
                Console.WriteLine(ScenarioContext.Current.TestError.Message);
                Console.WriteLine(ScenarioContext.Current.TestError.StackTrace);

                Logger.log.Info(ScenarioContext.Current.TestError.Message);
                Logger.log.Info(ScenarioContext.Current.TestError.StackTrace);
            }

        }


        //[BeforeScenario("ReviewerCommit")]
        //public void AssignZeroToTotalChanges()
        //{
        //    RemovedCount.totalChanges = 0;
        //}



        //#region Reassign Setup

        //int? DefaultParameterValue = null;
        //long UserID = 0;

        //public object ConfigurationManager { get; private set; }

        //[BeforeScenario("ReassignItem")]
        //public void ReassignSetup()
        //{
        //    DefaultParameterValue = Objects.objDatabaseOperation.GetAssignedItemMaxLimit(ConfigurationManager.AppSettings["ParameterName"]);
        //    Objects.objDatabaseOperation.UpdatetAssignedItemMaxLimit(ConfigurationManager.AppSettings["ParameterName"], Convert.ToInt32(ConfigurationManager.AppSettings["ParameterValue"]));
        //    UserID = Convert.ToInt64(Objects.objDatabaseOperation.CreateUser());

        //}

        //[AfterScenario("ReassignItem")]
        //public void ReassignTearDown()
        //{
        //    Objects.objDatabaseOperation.UpdatetAssignedItemMaxLimit(ConfigurationManager.AppSettings["ParameterName"], DefaultParameterValue);
        //    Objects.objDatabaseOperation.InactivateUser(UserID);
        //}

        //#endregion

        //#region Events Related to Queue Clearer

        ///// <summary>
        ///// Stop the MS SQL Server agent
        ///// </summary>
        //[BeforeScenario("QueueClearerByParameters")]
        //public void StopSQLServerAgent()
        //{

        //    // Helper.StopService(ConfigurationManager.AppSettings["SQLServerAgent"], ConfigurationManager.AppSettings["serverName"]);
        //    Console.WriteLine("MQL Server Agent service is stopped.");
        //}

        ///// <summary>
        ///// Stop the MS SQL Server agent
        ///// </summary>
        //[AfterScenario("QueueClearerByParameters")]
        //public void StartSQLServerAgent()
        //{
        //    // Helper.StartService(ConfigurationManager.AppSettings["SQLServerAgent"], ConfigurationManager.AppSettings["serverName"]);
        //    Console.WriteLine("MQL Server Agent service is started.");
        //}


       // #endregion

    }
}