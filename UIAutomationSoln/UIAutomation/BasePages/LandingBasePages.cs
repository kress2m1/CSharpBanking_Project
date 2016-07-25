using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

namespace UIAutomation.BasePages
{
    [TestClass]
    public class LandingBasePages
    {
        private IWebDriver _driver;

        /// <summary>
        /// These tasks should be completed before the tests are run
        /// </summary>
        [TestInitialize]
        public void PreCondition()
        {
            Console.WriteLine("Launch the browser here");
            _driver = new ChromeDriver();    
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.bjss.com");
        }

        [TestMethod]
        public void BjssPageTitle()
        {
            Console.WriteLine("Write some code here");
            _driver.FindElement(By.ClassName("logo_inner")).Click();
            string pageTitle = _driver.Title;
            Assert.AreEqual("Welcome to BJSS: the Award-Winning Delivery-Focused IT Consultancy - BJSS Limited", pageTitle);
        }

        [TestMethod]
        public void EnterSearchTerm()
        {
            Console.WriteLine("Check that the search term returns a result");
            By searchTerm = By.Name("s");
            _driver.FindElement(searchTerm).SendKeys("Stuart");
//            _driver.FindElement(By.ClassName("s")).SendKeys("Stuart");
        }

        /// <summary>
        /// These tasks are to be completed after the tests are completed
        /// </summary>
        [TestCleanup]
        public void PostCondition()
        {
            _driver.Quit();
        }
    }
}
