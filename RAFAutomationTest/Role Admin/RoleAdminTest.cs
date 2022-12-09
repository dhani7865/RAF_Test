using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    [TestCategory("Role Admin")]
    [TestClass]
    public class RoleAdminTest
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

            string reportPath = projectPath + "TestReport\\RAF Role Admin Button Test 18-11-2022.html";


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
        public void test_RoleAdminTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Role Admin Button Test").Info("Test Started");

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));

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
            // Clicking on the Role Admin button
            driver.FindElement(By.CssSelector("li:nth-child(5) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Role Admin button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the search button
            driver.FindElement(By.Id("lnkSearch")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the status for Open roles
            var dropdown = driver.FindElement(By.Id("statusId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Open");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the status for Open roles");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Selecting the status for Closed roles
            dropdown = driver.FindElement(By.Id("statusId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Closed");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the status for Closed roles");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the View Details button
            driver.FindElement(By.LinkText("View Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View Details button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the Back to Listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Listing button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the search button
            driver.FindElement(By.Id("lnkSearch")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Search button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Selecting and copying the marketing description
            driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(2)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting and copying the marketing description");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Entering the marketing description
            driver.FindElement(By.Id("marketingdescription")).Click();
            driver.FindElement(By.Id("marketingdescription")).SendKeys("Information and Communication Technology Technician Aerial Erector Qualified	");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the marketing description");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Entering the marketing description
            driver.FindElement(By.Id("marketingdescription")).Click();
            driver.FindElement(By.Id("marketingdescription")).SendKeys("Information and Communication Technology Technician Aerial Erector Qualified");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the marketing description");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Clicking the home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Clicking the Role Admin Button
            driver.FindElement(By.CssSelector("li:nth-child(5) img")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Role Admin Button");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the Search button
            driver.FindElement(By.Id("lnkSearch")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Search button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Selecting active for the closed role follow up
            dropdown = driver.FindElement(By.Id("isClosedRoleFollowUp"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Active");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting active for the closed role follow up");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Selecting Inactive for the closed role follow up
            dropdown = driver.FindElement(By.Id("isClosedRoleFollowUp"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Inactive");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Inactive for the closed role follow up");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Clicking the home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the Role Admin button
            driver.FindElement(By.CssSelector("li:nth-child(5) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Role Admin button");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Clicking the search button
            driver.FindElement(By.Id("lnkSearch")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Marketing Description
            // Test 26
            // Entering the marketing description
            driver.FindElement(By.Id("marketingdescription")).Clear();
            driver.FindElement(By.Id("marketingdescription")).SendKeys("Information and Communication Technology Technician Aerial Erector Qualified");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the marketing description");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Entering the marketing description
            driver.FindElement(By.Id("marketingdescription")).Clear();
            driver.FindElement(By.Id("marketingdescription")).SendKeys("Communications Infrastructure Technician");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the marketing description");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Entering the marketing description
            driver.FindElement(By.Id("marketingdescription")).Clear();
            driver.FindElement(By.Id("marketingdescription")).SendKeys("Air Cartographer");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the marketing description");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            // Test 30
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // CLicking the home button
            wait.Until(ExpectedConditions.ElementExists(By.LinkText("Home"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 31 Passed");
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

