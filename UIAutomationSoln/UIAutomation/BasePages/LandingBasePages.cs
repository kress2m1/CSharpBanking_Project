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
        [Owner("Andre Dada")]
        [TestCategory("BJSS")]
        public void BjssPageTitle()
        {
            Console.WriteLine("Check that the home page is displayed");
            string pageTitle = _driver.Title;
            Assert.AreEqual("Welcome to BJSS: the Award-Winning Delivery-Focused IT Consultancy - BJSS Limited", pageTitle);
        }

        [TestMethod]
        [Owner("Andre Dada")]
        [TestCategory("BJSS")]
        public void EnterSearchTerm()
        {
            Console.WriteLine("Check that the search term returns a result");
            _driver.FindElement(By.Name("s")).SendKeys("Stuart");
            //Navigate to the 'Contact' page
            _driver.FindElement(By.Id("nav-menu-item-10322")).Click();
            string contactPageTitle = _driver.Title;
            Assert.AreEqual("Contact BJSS - BJSS Limited", contactPageTitle);

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
