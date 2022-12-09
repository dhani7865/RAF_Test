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
    public class EventManagementTest
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

            string reportPath = projectPath + "TestReport\\RAF Event Management Button Test 21-11-2022.html";


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
        public void test_EventManagementTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Event Management Test").Info("Test Started");

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
            // Clicking on the Event Management Button
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(9) span"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Event Management Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the Session Search button
            driver.FindElement(By.LinkText("Search")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Session Search button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the Event Type ID
            var dropdown = driver.FindElement(By.Id("EventTypeId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Initial Enquiry Appointment");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, " Selecting the Event Type ID");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the Event Status
            dropdown = driver.FindElement(By.Id("SessionStatusId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("All");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Event Status");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the search button
            driver.FindElement(By.Id("SearchSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Selecting a event and viewing the details for the event
            driver.FindElement(By.CssSelector("#eventSessionRow_2130 a")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a event and viewing the details for the event");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the Back to results button
            driver.FindElement(By.Id("backtosearchresults")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to results button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Selecting a event attendance
            driver.FindElement(By.CssSelector("#eventSessionRow_2131 a:nth-child(3)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a event attendance");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the Back to results button
            driver.FindElement(By.Id("backtosearchresults")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to results button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the Event Management button
            driver.FindElement(By.LinkText("Event Management")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Event Management button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the create button to create a session
            driver.FindElement(By.LinkText("Create")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the create button to create a session");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Selecting the RecruitmentEventId
            dropdown = driver.FindElement(By.Id("RecruitmentEventId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("AFCO Birmingham - Initial Enquiry Appointment");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the RecruitmentEventId");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Selecting the SessionDate
            driver.FindElement(By.Id("SessionDate")).Click();
            driver.FindElement(By.Id("SessionDate")).SendKeys("05/12/2022");

            // driver.FindElement(By.CssSelector(".ui-datepicker-month")).Click();

            // driver.FindElement(By.LinkText("2")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SessionDate");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Entering the Session Start Time
            driver.FindElement(By.Id("SessionStartTime")).Click();
            driver.FindElement(By.Id("SessionStartTime")).SendKeys("06:00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Session Start Time");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Entering the SessionEndTime
            driver.FindElement(By.Id("SessionEndTime")).Click();
            driver.FindElement(By.Id("SessionEndTime")).SendKeys("17:00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the SessionEndTime");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Entering the TotalCapacity
            driver.FindElement(By.Id("TotalCapacity")).Click();
            driver.FindElement(By.Id("TotalCapacity")).SendKeys("1");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the TotalCapacity");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the Create Session Submit button
            driver.FindElement(By.Id("CreateSessionSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create Session Submit button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the cancel session button
            driver.FindElement(By.Id("btncancelsession")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the cancel session button");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Selecting Yes on the Dialogue
            driver.FindElement(By.Id("YesNoDialogueYes")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes on the Dialogue");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Clicking the search button to search for a event
            driver.FindElement(By.CssSelector(".horizontal-tabs:nth-child(8) a:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button to search for a event");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Selecting the EventTypeId
            dropdown = driver.FindElement(By.Id("EventTypeId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Initial Enquiry Appointment");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the EventTypeId");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Selecting the EventAFCOId
            dropdown = driver.FindElement(By.Id("EventAFCOId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Edinburgh");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the EventAFCOId");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the search button
            driver.FindElement(By.Id("SearchSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Clicking the View/Edit button
            driver.FindElement(By.LinkText("View/Edit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View/Edit button");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Clicking the Edit Event button
            driver.FindElement(By.LinkText("Edit Event")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Edit Event button");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Clicking the EventUpdateSubmit button
            driver.FindElement(By.Id("EventUpdateSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the EventUpdateSubmit button");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Clicking the Event Management button
            driver.FindElement(By.LinkText("Event Management")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Event Management button");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Clicking the event search button
            driver.FindElement(By.CssSelector(".horizontal-tabs:nth-child(8) a:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector("fieldset")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the event search button");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Selecting the EventTypeId
            dropdown = driver.FindElement(By.Id("EventTypeId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Initial Enquiry Appointment");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the EventTypeId");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            // Test 30
            // Selecting the EventAFCOId
            dropdown = driver.FindElement(By.Id("EventAFCOId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Brighton");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the EventAFCOId");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Clicking the Search button
            driver.FindElement(By.Id("SearchSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Search button");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Clicking the Schedule button
            driver.FindElement(By.LinkText("Schedule")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Schedule button");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            // Test 33
            // Clicking the delete button
            driver.FindElement(By.CssSelector(".sessionrow:nth-child(2) .deleterow")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Delete button");
            test.Log(Status.Pass, "Test 33 Passed");
            extent.Flush();

            // Test 34
            // Clicking the add button
            driver.FindElement(By.Id("btnAdd")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the add button");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();

            // Test 35
            // Selecting the DayOfWeekId
            dropdown = driver.FindElement(By.Id("Configs_8__DayOfWeekId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Mon");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the DayOfWeekId");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 36
            // Entering the Start Time
            driver.FindElement(By.Id("Configs_8__StartTime")).Click();
            driver.FindElement(By.Id("Configs_8__StartTime")).SendKeys("07:00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Start Time");
            test.Log(Status.Pass, "Test 36 Passed");
            extent.Flush();

            // Test 37
            // Entering the End Time
            driver.FindElement(By.Id("Configs_8__EndTime")).Click();
            driver.FindElement(By.Id("Configs_8__EndTime")).SendKeys("18:00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the End Time");
            test.Log(Status.Pass, "Test 37 Passed");
            extent.Flush();

            // Test 38
            // Entering the capacity
            driver.FindElement(By.Id("Configs_8__Capacity")).Click();
            driver.FindElement(By.Id("Configs_8__Capacity")).SendKeys("1");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the capacity");
            test.Log(Status.Pass, "Test 38 Passed");
            extent.Flush();

            // Test 39
            // Clicking the Update Event Schedule button
            driver.FindElement(By.Id("configsubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Update Event Schedule button");
            test.Log(Status.Pass, "Test 39 Passed");
            extent.Flush();

            // Test 40
            // Clicking Yes on the dialogue button
            driver.FindElement(By.Id("YesNoDialogueYes")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking Yes on the dialogue button");
            test.Log(Status.Pass, "Test 40 Passed");
            extent.Flush();

            // Test 41
            // Clicking the Home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Home button");
            test.Log(Status.Pass, "Test 41 Passed");
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
