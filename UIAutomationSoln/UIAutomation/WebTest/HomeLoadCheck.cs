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
            _driver.Navigate().GoToUrl("http://www.asda.com");

            Console.WriteLine("Display the list of cookies on the website");
            IList<Cookie> cookies = _driver.Manage().Cookies.AllCookies;
            foreach (var cookie in cookies)
            {
                Console.WriteLine("The list of cookies {0} \n", cookie.ToString());
            }
        }

        [TestMethod]
        [Owner("Andre Dada")]
        [TestCategory("Home Page Test")]
        public void CheckPageUrl()
        {
            string urlCheck = _driver.Url;
            Console.WriteLine(urlCheck);
            bool asserCheckUrl = _driver.Url.ToLower().Contains("www.asda.com".ToLower());
            Assert.IsTrue(asserCheckUrl, "Does not contain {0}", "www.asda.com.".ToLower());
        }


        [TestMethod]
        [Owner("Andre Dada")]
        [TestCategory("Home Page Test")]
        public void CheckHomePageIsLoaded()
        {
            Console.WriteLine("Check that the homepage is loaded");
            //_driver.FindElement(By.ClassName("section__title"));
            bool assertCheck = _driver.PageSource.ToLower().Contains("Explore more at Asda".ToLower());
            Assert.IsTrue(assertCheck, "Does not contain {0}", "Explore more at Asda");
        }

        [TestMethod]
        [Owner("Andre Dada")]
        [TestCategory("Home Page Test")]
        public void CheckPageTitle()
        {
            string asdaTitle = _driver.Title;
            Assert.AreEqual("Asda.com - Online Food Shopping, George, & more".ToLower(), asdaTitle.ToLower());
        }

        [TestMethod]
        [Owner("Andre Dada")]
        [TestCategory("Home Page Test")]
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
