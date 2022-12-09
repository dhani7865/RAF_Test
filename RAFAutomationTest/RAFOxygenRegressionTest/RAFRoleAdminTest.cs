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
    [TestCategory("RAF Oxygen Regression Test")]
    [TestClass]
    public class RAFRoleAdminTest
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

            string reportPath = projectPath + "TestReport\\RAF Role Admin Button Test 21-11-2022.html";


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
        public void test_RAFRoleAdminTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Role Admin Test").Info("Test Started");

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
            // Clicking on the Role Admin Button
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(5) img"))).Click();

            // driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Role Admin Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the edit button
            driver.FindElement(By.LinkText("Edit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the edit button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the save button
            driver.FindElement(By.CssSelector("input:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Clicking the Back to Listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Listing button");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the View details button
            driver.FindElement(By.LinkText("View Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View details button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the Back to Listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Listing button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the Create New button
            driver.FindElement(By.LinkText("Create New")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create New button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Enterring test for the value
            driver.FindElement(By.Id("Value")).Click();
            driver.FindElement(By.Id("Value")).SendKeys("Test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the value");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Enterring This is a test for the Description
            driver.FindElement(By.Id("Description")).Click();
            driver.FindElement(By.Id("Description")).SendKeys("This is a test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring This is a test for the Description");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Enterring This is a test for the Marketing Description
            driver.FindElement(By.Id("MarketingDescription")).Click();
            driver.FindElement(By.Id("MarketingDescription")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring This is a test for the Marketing Description");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Selecting the Role Status Id from the dropdown
            var dropdown = driver.FindElement(By.Id("RoleStatusId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Open");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting open from the dropdown");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Selecting the Role Group Id from the dropdown
            dropdown = driver.FindElement(By.Id("RoleGroupId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("People Operations");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Role Group Id from the dropdown");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Setting the RoleTypeId
            dropdown = driver.FindElement(By.Id("RoleTypeId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Regulars");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Setting the RoleTypeId");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Setting the RoleCareerLevelId
            dropdown = driver.FindElement(By.Id("RoleCareerLevelId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("P2");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Setting the RoleCareerLevelId");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Selecting the RoleEmailTextId
            dropdown = driver.FindElement(By.Id("RoleEmailTextId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Regiment Officer");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the RoleEmailTextId");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Enterring test for the OnlineUrl
            driver.FindElement(By.Id("OnlineUrl")).Click();
            driver.FindElement(By.Id("OnlineUrl")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the OnlineUrl");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();


            // Test 18
            // Selecting active
            driver.FindElement(By.Id("IsActive")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting active");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the create button
            driver.FindElement(By.CssSelector(".bottom-padding")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the create button");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Clicking the View History button
            driver.FindElement(By.LinkText("View History")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View History button");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Clicking the Back to Details button
            driver.FindElement(By.LinkText("Back to Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Details button");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the Back to Listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Listing button");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Clicking the search button
            driver.FindElement(By.Id("lnkSearch")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Enterring the value test in the search criteria
            driver.FindElement(By.Id("value")).Click();
            driver.FindElement(By.Id("value")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the value test in the search criteria");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Clicking the search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Selecting view details for a role admin
            driver.FindElement(By.CssSelector("tr:nth-child(2) a:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting view details for a role admin");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Clicking the back to listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the back to listing button");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Clicking the manage role groups button
            driver.FindElement(By.LinkText("Manage Role Groups")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the manage role groups button");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Clicking the view details button
            driver.FindElement(By.LinkText("View Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the view details button");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            // Test 30
            // Clicking the Back to Listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Listing button");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Clicking the home button to go back to the home page
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button to go back to the home page");
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
