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
    public class LoginTest
    {
        private IWebDriver _driver;

        /// <summary>
        /// These tasks must be run before the tests start
        /// </summary>
        [TestInitialize]
        public void PreCondition()
        {
            Console.WriteLine("These tasks must be run before the tests are run");
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();    
        }

        [TestMethod]
        [Owner("Andre Dada")]
        [TestProperty("Browser", "Launch")]
        [TestCategory("SmokeTest")]
        public void LaunchBrowser()
        {
            Console.WriteLine("Check that the browser is launched and maximised");
        }
         
        [TestMethod]
        [Owner("Andre Dada")]
        [TestProperty("Login", "Username")]
        [TestCategory("SmokeTest")]
        public void LoginToTescoAccount()
        {
            Console.WriteLine("Check that the user is able to log into their account");
        }

        /// <summary>
        /// These tasks must be run after the tests are completed
        /// </summary>
        [TestCleanup]
        public void PostCondition()
        {
            Console.WriteLine("These tasks must be run after the tests runs are completed");
            _driver.Quit();
        }

    }
}
