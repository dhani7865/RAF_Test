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
    [TestCategory("Story_20236_RAF_Changes_to_Non_DMC_Outbound")]

    [TestClass]
    public class StartScriptNonDMCOutboundTest
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

            string reportPath = projectPath + "TestReport\\RAF - Start Script - Non DMC Outbound Test 22-11-2022.html";


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
        public void test_StartScriptNonDMCOutboundTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Start Script - Non DMC Outbound Test").Info("Test Started");

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

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
            // Clicking the Start Script button
            driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Start Script button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the Career Service Id
            var dropdown = driver.FindElement(By.Id("CareerServiceId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("RAF Careers");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Service Id");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the Title ID
            dropdown = driver.FindElement(By.Id("SelectedTitleId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Mr");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Title ID");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Scrolling back into view and finding the element for the button to click on
            ScrollintoView(driver, By.Id("FirstName"));

            // Test 5
            // Entering the FirstName
            driver.FindElement(By.Id("FirstName")).Click();
            driver.FindElement(By.Id("FirstName")).SendKeys("Third");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the FirstName");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Entering the LastName
            driver.FindElement(By.Id("LastName")).Click();
            driver.FindElement(By.Id("LastName")).SendKeys("Teleperformance");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the LastName");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the Continue button
            driver.FindElement(By.Id("ScriptStartSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Continue button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Selecting Repeat Caller
            driver.FindElement(By.CssSelector(".option-ctrl:nth-child(2) > label")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Repeat Caller");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the continue button
            driver.FindElement(By.Id("MediaSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the Role Registeration button
            driver.FindElement(By.Id("Role Registration")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Role Registeration button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Enterring the postcode
            driver.FindElement(By.Id("PostCode")).Click();
            driver.FindElement(By.Id("PostCode")).SendKeys("BS1 3LG");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the postcode");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Enterring the Email Address
            driver.FindElement(By.Id("EmailAddress")).Click();
            driver.FindElement(By.Id("EmailAddress")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the EmailAddress");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Enterring the DateOfBirth
            driver.FindElement(By.Id("DateOfBirth")).Click();
            driver.FindElement(By.Id("DateOfBirth")).SendKeys("01/01/2000");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the DateOfBirth");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the Search button
            driver.FindElement(By.Id("SearchSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Search button");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Clicking the Create a new Contact button
            driver.FindElement(By.LinkText("Create a new Contact")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create a new Contact button");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Selecting the gender
            dropdown = driver.FindElement(By.Id("Gender_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Male");
            // selectElement.SelectByText("Female");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Gender");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Selecting the Ethnicity
            dropdown = driver.FindElement(By.Id("Ethnicity_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Pakistani");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Ethnicity");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Selecting the Nationality
            dropdown = driver.FindElement(By.Id("Nationality_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("British or Mixed British");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Nationality");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Entering the Telephone - Mobile number
            driver.FindElement(By.Id("ContactMethods_3__Value")).Click();
            driver.FindElement(By.Id("ContactMethods_3__Value")).SendKeys("07982871086");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Telephone - Mobile number");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Selecting email and SMS
            driver.FindElement(By.Id("ContactMethods_4__IsOptOut")).Click();
            driver.FindElement(By.Id("ContactMethods_5__IsOptOut")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting email and SMS");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Selecting the address
            dropdown = driver.FindElement(By.Id("Addresses_0__Type_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Home");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Enterring the postcode for the address search
            driver.FindElement(By.Id("Addresses_0__Postcode")).Click();
            driver.FindElement(By.Id("Addresses_0__Postcode")).SendKeys("BS1 3LG");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the postcode for the address search");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Clicking the Create Contact button
            driver.FindElement(By.Id("ContactCreateSubmit")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create Contact button");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the Role Registeration button
            driver.FindElement(By.Id("Role Registration")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Role Registeration button");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Clicking the Create a new Registration button
            driver.FindElement(By.LinkText("Create a new Registration")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create a new Registration button");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Selecting the SelectedMilitaryServiceBranchId
            dropdown = driver.FindElement(By.Id("SelectedMilitaryServiceBranchId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Royal Air Force");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedMilitaryServiceBranchId");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Selecting the SelectedRoleTypeId
            dropdown = driver.FindElement(By.Id("SelectedRoleTypeId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Regulars");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedRoleTypeId");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Selecting the SelectedRoleGroupId
            dropdown = driver.FindElement(By.Id("SelectedRoleGroupId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Medical and Medical Support");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedRoleGroupId");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Clicking the search button
            driver.FindElement(By.Id("RegularsSearchButtonId")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            // Test 30
            // Selecting Medical and Medical Support : Biomedical Scientist
            driver.FindElement(By.LinkText("Select")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Medical and Medical Support : Biomedical Scientist");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Selecting IsEligible
            dropdown = driver.FindElement(By.Id("IsEligible"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Checked & Eligible");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting IsEligible");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Clicking the submit button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            // Test 33
            // Clicking the Schedule Callback button
            driver.FindElement(By.CssSelector("#Schedule\\ Callback > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Schedule Callback button");
            test.Log(Status.Pass, "Test 33 Passed");
            extent.Flush();

            // Test 34
            // Selecting Scheduled Time
            dropdown = driver.FindElement(By.Id("CallbackTaskCreate_TaskSlotId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("+1 Hour");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Scheduled Time");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();

            // Test 35
            // Clicking the Save button
            driver.FindElement(By.Name("command")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Save button");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 36
            // Clicking the finish button
            driver.FindElement(By.CssSelector("#Finish > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 36 Passed");
            extent.Flush();

            // Test 37
            // Selecting the Outcome ID
            driver.FindElement(By.Id("SelectedOutcome_ID")).Click();
            {
                dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));
                dropdown.FindElement(By.XPath("//option[. = 'Registration Successful']")).Click();
            }

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Outcome ID");
            test.Log(Status.Pass, "Test 37 Passed");
            extent.Flush();

            // Test 38
            // Clicking the finish button
            driver.FindElement(By.CssSelector(".cti")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 37 Passed");
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

