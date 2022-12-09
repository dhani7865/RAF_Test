﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.NetworkInformation;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAF_SELENIUM_TESTS
{
    [TestCategory("RAF Regulars Role Email")]
    [TestClass]
    public class RAFCallForwardTest
    {
        private static ExtentReports extent;

        private String test_url = "https://tpoxygen-raf-recruitment-qa/";
        private IWebDriver _driver;

        public IWebDriver driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new ChromeDriver();
                    _driver.Manage().Window.Maximize();
                }

                return _driver;
            }

        }

        public string Title
        {
            get { return driver.Title; }
        }

        public void Goto(string url)
        {
            driver.Url = url;
        }

        public void Close()
        {
            driver.Quit();
        }



        // Start method for extent reports
        [OneTimeSetUp]
        public static void ExtentStart()
        {
            extent = new ExtentReports();

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "TestReport\\RAF Call Forward Test Button 21-11-2022.html";


            var htmlReporter = new ExtentV3HtmlReporter(reportPath);

            extent.AttachReporter(htmlReporter);

        }



        public void ExtentClose()
        {
            extent.Flush();
        }


        [TestMethod]
        // Creating a public static method for the radio buttons and creating a for each loop to get the attribute ID for the radio buttons
        public static void SelectRadioButtonWithIdStarting(string Id, IWebDriver driver)
        {
            var elements = driver.FindElements(By.XPath("//input[@type='radio']"));
            var isClicked = false;

            foreach (var item in elements)
            {
                if (item.Displayed && item.Enabled && isClicked == false)
                {
                    var radio = item.GetAttribute("id");
                    if (radio.StartsWith(Id))
                    {
                        item.Click();
                        isClicked = true;
                    }
                }
            }
            NUnit.Framework.Assert.IsTrue(isClicked);
        }

        // Scroll into view method
        private static void ScrollintoView(IWebDriver driver, By bySelector)
        {
            var element = driver.FindElement(bySelector);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }


        [TestMethod]
        public void test_RAFCallForwardTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Call Forward Test").Info("Test Started");

            // Test 1
            // Going to the url
            Goto(test_url);

            // Perform wait to check the output
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "RAF QA Oxygon Launched");
            test.Log(Status.Pass, "Test 1 Passed");
            extent.Flush();


            // Test 2
            // Clicking on the Start Script Button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            driver.FindElement(By.CssSelector("li:nth-child(8) span")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Start Script Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the Send Test Email Button
            driver.FindElement(By.LinkText("Send Test Email")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Send Test Email Button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the RoleId for regulars
            driver.FindElement(By.Id("SelectedRoleId")).Click();

            var dropdown = driver.FindElement(By.Id("SelectedRoleId"));
            dropdown.FindElement(By.XPath("//option[. = 'Regulars ▸ aaaa - Air and Space Operations [Open]']")).Click();

            // dropdown.FindElement(By.XPath("//option[. = 'Regulars ▸ Aerospace Systems Operator - Air and Space Operations [Closed]']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the RoleId for regulars");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Entering the Email
            driver.FindElement(By.Id("EmailAddress")).Click();
            driver.FindElement(By.Id("EmailAddress")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Email");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Entering the Last Name
            driver.FindElement(By.Id("ContactName")).Click();
            driver.FindElement(By.Id("ContactName")).SendKeys("teleperformance");

            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.Id("ContactName")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("ContactName")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("ContactName")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("ContactName")).SendKeys(Keys.Down);

            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.Id("ContactName")).SendKeys(Keys.Enter);


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the contact name");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Test 19
            // Clicking the send test email button
            driver.FindElement(By.CssSelector("form > input")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the send test email button");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // quit driver after all tests completed
            driver.Quit();

        }

        [TearDown]
        public void close_Browser()
        {
            Close();
        }
    }
}
