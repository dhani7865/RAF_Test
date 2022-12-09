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
    [TestCategory("Story 19865 - RAF - Domain Changes")]
    [TestClass]
    public class StartScriptReservesClosedRoleDomainChangesTest
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

            string reportPath = projectPath + "TestReport\\RAF - Start Script - Reserves Closed Role Domain Changes Test 22-11-2022.html";


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
        public void test_StartScriptReservesClosedRoleDomainChangesTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Start Script - Reserve Closed Role Domain Changes Test").Info("Test Started");

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
            // Clicking on the Start Script Button

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(1) img"))).Click();

            // driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Start Script Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the Career Service ID from the dropdown
            var dropdown = driver.FindElement(By.Id("CareerServiceId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("RAF Reserves");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Service ID from the dropdown");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the Title ID from the dropdown
            dropdown = driver.FindElement(By.Id("SelectedTitleId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Mr");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Title ID from the dropdown");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Entering the FirstName
            driver.FindElement(By.Id("FirstName")).Click();
            driver.FindElement(By.Id("FirstName")).SendKeys("First");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the FirstName");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Entering the LastName
            driver.FindElement(By.Id("LastName")).Click();
            driver.FindElement(By.Id("LastName")).SendKeys("Name");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the LastName");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the continue button
            driver.FindElement(By.Id("ScriptStartSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Selecting New caller
            driver.FindElement(By.CssSelector(".option-ctrl:nth-child(3) > label")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting New caller");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Selecting the media ID
            dropdown = driver.FindElement(By.Id("SelectedMediaId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Email message");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the media ID");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Selecitng the HasSeenAdvert
            dropdown = driver.FindElement(By.Id("HasSeenAdvert"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("No");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecitng the HasSeenAdvert");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Selecting HasSpokenWithRecruiter
            dropdown = driver.FindElement(By.Id("HasSpokenWithRecruiter"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("No");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Has Spoken With Recruiter");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Selecting HasBeenToEvent
            dropdown = driver.FindElement(By.Id("HasBeenToEvent"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("No");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Has Been To Event");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Clicking the continue button
            driver.FindElement(By.Id("MediaSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the Role Registration button
            driver.FindElement(By.Id("Role Registration")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Role Registration button");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Entering the PostCode
            driver.FindElement(By.Id("PostCode")).Click();
            driver.FindElement(By.Id("PostCode")).SendKeys("BS1 3LG");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the PostCode");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Entering the EmailAddress
            driver.FindElement(By.Id("EmailAddress")).Click();
            driver.FindElement(By.Id("EmailAddress")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the EmailAddress");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Entering the DateOfBirth
            driver.FindElement(By.Id("DateOfBirth")).Click();
            driver.FindElement(By.Id("DateOfBirth")).SendKeys("01/02/1990");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the DateOfBirth");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the search button
            driver.FindElement(By.Id("SearchSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the Create a new Contact button
            driver.FindElement(By.LinkText("Create a new Contact")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create a new Contact button");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Selecting the gender
            dropdown = driver.FindElement(By.Id("Gender_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Male");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the gender");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Selecting the Ethnicity ID
            dropdown = driver.FindElement(By.Id("Ethnicity_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Pakistani");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Ethnicity ID");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Selecting the Nationality ID
            dropdown = driver.FindElement(By.Id("Nationality_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("British or Mixed British");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Nationality ID");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Entering the Telephone - Day
            driver.FindElement(By.Id("ContactMethods_1__Value")).Click();
            driver.FindElement(By.Id("ContactMethods_1__Value")).SendKeys("07982871086");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Telephone - Day");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Selecting the address type
            dropdown = driver.FindElement(By.Id("Addresses_0__Type_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Home");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address type");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Enterring the postcode for the address search
            driver.FindElement(By.Id("Addresses_0__Postcode")).Click();
            driver.FindElement(By.Id("Addresses_0__Postcode")).SendKeys("bs1 3lg");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the postcode for the search string");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            /*
            // Test 26
            // Clicking on the lookup button and waiting for the dropdown to appear
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("lookup"))).Click();

            System.Threading.Thread.Sleep(2000);


            // Test 28
            // Finding the element and address from the dopdown and clicking on the element. 
            dropdown = driver.FindElement(By.Id("Addresses_0__SelectedSearchResult"));

            System.Threading.Thread.Sleep(5000);

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Teleperformance, Spectrum House, Bond Street, BRISTOL");


            // Selecting the address from the search result and double clicking on the element
            driver.FindElement(By.ClassName("use")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Finding the element and address from the dopdown and clicking on the element. ");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Selecting the Date Left Education
            driver.FindElement(By.Id("LeftEducationDate")).Click();
            driver.FindElement(By.LinkText("26")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting theDate  Left Education");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();
            */

            // Test 28
            // Clicking the Create Contact Button
            driver.FindElement(By.Id("ContactCreateSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create Contact Button");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Clicking the Role Registration button and Create a new Registration
            driver.FindElement(By.Id("Role Registration")).Click();
            driver.FindElement(By.LinkText("Create a new Registration")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Role Registration button and Create a new Registration button");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            // Test 30
            // Selecting the Military Service Branch Id
            dropdown = driver.FindElement(By.Id("SelectedMilitaryServiceBranchId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Royal Air Force");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Military Service Branch Id");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Selecting the Role type ID
            dropdown = driver.FindElement(By.Id("SelectedRoleTypeId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Reserves");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Role type ID");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Selecting the Squadron Id
            dropdown = driver.FindElement(By.Id("SelectedSquadronId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Cardiff - 614 Sqn - 28 Miles");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Squadron Id");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            // Test 33
            // Selecting the Reserves Role Id
            dropdown = driver.FindElement(By.Id("SelectedReservesRoleId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Logistics (Driver) (Closed)");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Reserves Role Id");
            test.Log(Status.Pass, "Test 33 Passed");
            extent.Flush();

            // Test 34
            // Clicking the Search Button ID
            driver.FindElement(By.Id("ReservesSearchButtonId")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Search Button ID");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();

            // Test 35
            // Clicking the select button
            driver.FindElement(By.LinkText("Select")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the select button");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 36
            // Selecting Eligible
            dropdown = driver.FindElement(By.Id("IsEligible"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Checked & Eligible");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Eligible");
            test.Log(Status.Pass, "Test 36 Passed");
            extent.Flush();

            // Test 37
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 37 Passed");
            extent.Flush();

            // Test 38
            // Clicking the finish button
            driver.FindElement(By.CssSelector("#Finish > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 38 Passed");
            extent.Flush();

            // Test 39
            // Selecting the outcome ID
            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Registration Successful");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the outcome ID");
            test.Log(Status.Pass, "Test 39 Passed");
            extent.Flush();

            // Test 40
            // Clicking the finish button
            driver.FindElement(By.CssSelector(".cti")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 40 Passed");
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

