using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomation.WebTest
{
    [TestClass]
    public class HomeLoadCheck
    {
        //Initialise the instance of the Iwebdriver
        private IWebDriver _driver;

        /// <summary>
        /// These tasks must be run before the tests commence
        /// </summary>
        [TestInitialize]
        public void PreCondition()
        {
            Console.WriteLine("These tasks must be run before the tests begin");
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [TestMethod, TestCategory("Home Page Test")]
        public void CheckHomePageIsLoaded()
        {
            Console.WriteLine("Check that the browser is loaded");
        }

        [TestMethod, TestCategory("Home Page Test"), Ignore]
        public void CheckBrowserIsMaximised()
        {
            Console.WriteLine("Check that the browser is maximised");
        }

        /// <summary>
        /// These tests must be run after the tests have been run
        /// </summary>
        [TestCleanup]
        public void PostCondition()
        {
            Console.WriteLine("These tasks must be run after the tests have been run");
            _driver.Quit(); 
        }
    }
}
