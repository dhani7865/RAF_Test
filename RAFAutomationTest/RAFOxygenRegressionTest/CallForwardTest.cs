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
    public class CallForwardTest
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

            string reportPath = projectPath + "TestReport\\RAF Call Forward Button Test 21-11-2022.html";


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
        public void test_CallForwardTest()
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
            // Clicking on the Call Forward Button
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(8) img"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Call Forward Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the Create new button
            driver.FindElement(By.LinkText("Create New")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create new button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the Start Date
            driver.FindElement(By.Id("StartDate")).Click();
            driver.FindElement(By.LinkText("6")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Start Date");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the End Date
            driver.FindElement(By.Id("EndDate")).Click();
            driver.FindElement(By.LinkText("14")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the End Date");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the create call forward button
            driver.FindElement(By.CssSelector("input:nth-child(5)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the create call forward button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Selecting the RoleId for regulars
            driver.FindElement(By.Id("SelectedRoleId")).Click();

            var dropdown = driver.FindElement(By.Id("SelectedRoleId"));
            dropdown.FindElement(By.XPath("//option[. = 'Regulars ▸ Air Cartographer long - Air and Space Operations [Open]']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the RoleId for regulars");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the Call Forward Button
            driver.FindElement(By.CssSelector("input:nth-child(5)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Call Forward Button");
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
            // Clicking the send test email button
            driver.FindElement(By.LinkText("Send Test Email")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the send test email button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Selecting the SelectedRoleId
            driver.FindElement(By.Id("SelectedRoleId")).Click();

            dropdown = driver.FindElement(By.Id("SelectedRoleId"));
            dropdown.FindElement(By.XPath("//option[. = 'Regulars ▸ Aerospace Systems Operator - Air and Space Operations [Closed]']")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedRoleId");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Enterring the email address
            driver.FindElement(By.Id("EmailAddress")).Click();
            driver.FindElement(By.Id("EmailAddress")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the email address");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Enterring the Contact Name Teleperformance North
            driver.FindElement(By.Id("ContactName")).SendKeys("Teleperformance North");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the Contact Name Teleperformance North");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 16
            // Selecting Reserve role
            // Selecting the SelectedRoleId
            driver.FindElement(By.Id("SelectedRoleId")).Click();

            dropdown = driver.FindElement(By.Id("SelectedRoleId"));
            dropdown.FindElement(By.XPath("//option[. = 'Reserves ▸ Biomedical Scientist - Reserves [Open]']")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Reserve role");
            test.Log(Status.Info, "Selecting the SelectedRoleId");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Enterring the email address
            driver.FindElement(By.Id("EmailAddress")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the email address");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Enterring and selecting the contact name
            driver.FindElement(By.Id("ContactName")).Click();

            driver.FindElement(By.Id("ContactName")).Clear();

            System.Threading.Thread.Sleep(5000);


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
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the send test email button
            driver.FindElement(By.CssSelector("form > input")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the send test email button");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Clicking the Back to Listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Listing buttonn");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the view details button
            driver.FindElement(By.LinkText("View Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the view details button");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Clicking the Back to Listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Listing buttonn");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(1000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 24 Passed");
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
