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
    [TestCategory("Story 20795 - Event Session Details Obfuscated")]
    [TestClass]
    public class StartScriptObfuscatedContactTest
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

            string reportPath = projectPath + "TestReport\\RAF Start Script Button - Remove/Obfuscate Contact Test 17-11-2022.html";


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
        public void test_StartScriptObfuscatedContactTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Start Script Remove/Obfuscate Contact Test").Info("Test Started");

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
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(1) img"))).Click();

            // driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Start Script Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the Career Service ID from the dropdown
            var dropdown = driver.FindElement(By.Id("CareerServiceId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("RAF Careers");
            // selectElement.SelectByText("RAF AFCO Referral");



            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Service ID from the dropdown");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the title ID from the dropdown
            dropdown = driver.FindElement(By.Id("SelectedTitleId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Mr");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the title ID from the dropdown");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Test 5
            // Enterring test for the firstname
            driver.FindElement(By.Id("FirstName")).SendKeys("RAF");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the firstname");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Enterring test for the LastName
            driver.FindElement(By.Id("LastName")).SendKeys("Automation");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the LastName");
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
            // Clicking Repeat Caller
            driver.FindElement(By.CssSelector(".option-ctrl:nth-child(2) > label")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking Repeat Caller");
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
            // Clicking the role registeration button
            driver.FindElement(By.Id("Role Registration")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the role registeration button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the search button
            driver.FindElement(By.Id("SearchSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the Create a new Contact button
            driver.FindElement(By.LinkText("Create a new Contact")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create a new Contact button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Selecting the Gender
            dropdown = driver.FindElement(By.Id("Gender_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Male");
            // selectElement.SelectByText("Female");
            // selectElement.SelectByText("Prefer not to say");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Gender");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Selecting the date of birth
            driver.FindElement(By.Id("DateOfBirth")).Click();
            driver.FindElement(By.Id("DateOfBirth")).SendKeys("08/10/1992");


            // driver.FindElement(By.CssSelector(".ui-datepicker-year")).Click();
            // driver.FindElement(By.LinkText("11")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the date of birth");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Selecting the Ethnicity
            dropdown = driver.FindElement(By.Id("Ethnicity_ID"));

            selectElement = new SelectElement(dropdown);
            // selectElement.SelectByText("English / Welsh / Scottish / Northern Irish / British");
            selectElement.SelectByText("Pakistani");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Ethnicity");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Selecting the Nationality
            dropdown = driver.FindElement(By.Id("Nationality_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("British or Mixed British");
            // selectElement.SelectByText("Irish");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Nationality");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Entering the email
            driver.FindElement(By.Id("ContactMethods_0__RequiredValue")).Click();
            driver.FindElement(By.Id("ContactMethods_0__RequiredValue")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the email");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Enterring the Telephone - Mobile
            driver.FindElement(By.Id("ContactMethods_3__Value")).Clear();
            driver.FindElement(By.Id("ContactMethods_3__Value")).SendKeys("07982871086");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the Telephone - Mobile");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Selecting opt out for email and sms
            // driver.FindElement(By.Id("ContactMethods_4__IsOptOut")).Click();
            driver.FindElement(By.Id("ContactMethods_5__IsOptOut")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting opt out for sms");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Selecting the address
            dropdown = driver.FindElement(By.Id("Addresses_0__Type_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Home");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            driver.FindElement(By.CssSelector(".script")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Entering the Postcode
            driver.FindElement(By.Id("Addresses_0__Postcode")).Click();
            driver.FindElement(By.Id("Addresses_0__Postcode")).SendKeys("BS1 3LG");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Postcode");
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
            // Clicking the role registeration button
            driver.FindElement(By.Id("Role Registration")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the role registeration button");
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
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedRoleTypeId");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Selecting the SelectedRoleGroupId
            dropdown = driver.FindElement(By.Id("SelectedRoleGroupId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Engineering and Technical");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
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
            // Selecting Engineering and Technical
            // driver.FindElement(By.CssSelector("tr:nth-child(3) .selectLink")).Click();
            driver.FindElement(By.LinkText("Select")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Engineering and Technical");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Selecting IsEligible
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("IsEligible")));

            dropdown = driver.FindElement(By.Id("IsEligible"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Checked & Eligible");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting IsEligible");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            // Test 33
            // Clicking the schedule callback button
            driver.FindElement(By.CssSelector("#Schedule\\ Callback > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the schedule callback button");
            test.Log(Status.Pass, "Test 33 Passed");
            extent.Flush();

            // Test 34
            // Selecting the Callback Task Create Task Slot Id
            dropdown = driver.FindElement(By.Id("CallbackTaskCreate_TaskSlotId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("+1 Hour");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Callback Task Create Task Slot Id");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();


            // Test 35
            // Clicking the save button
            driver.FindElement(By.Name("command")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 36
            // Clicking the events button
            driver.FindElement(By.CssSelector("#Events > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, " Clicking the events button");
            test.Log(Status.Pass, "Test 36 Passed");
            extent.Flush();

            // Test 37
            // Clicking the Book appointment button
            driver.FindElement(By.LinkText("Book appointment")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Book appointment button");
            test.Log(Status.Pass, "Test 37 Passed");
            extent.Flush();

            // Test 38
            // Selecting the Events Type
            dropdown = driver.FindElement(By.Id("EventTypeId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Initial Enquiry Appointment");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Events Type");
            test.Log(Status.Pass, "Test 38 Passed");
            extent.Flush();

            // Test 39
            // Selecting the Event AFCO
            dropdown = driver.FindElement(By.Id("EventAFCOId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Bristol");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Event AFCO");
            test.Log(Status.Pass, "Test 39 Passed");
            extent.Flush();

            // Test 40
            // Clicking the search button
            driver.FindElement(By.Id("SearchSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 40 Passed");
            extent.Flush();

            // Test 41
            // Clicking the Detail button to book a appointment
            driver.FindElement(By.CssSelector("#eventSessionRow_917 a")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Detail button to book a appointment");
            test.Log(Status.Pass, "Test 41 Passed");
            extent.Flush();

            // Test 42
            // Clicking the Book Appointment button
            driver.FindElement(By.Id("btnbooksession")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Book Appointment button");
            test.Log(Status.Pass, "Test 42 Passed");
            extent.Flush();

            // Test 43
            // Clicking YES on the Dialogue
            driver.FindElement(By.Id("YesNoDialogueYes")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking YES on the Dialogue");
            test.Log(Status.Pass, "Test 43 Passed");
            extent.Flush();

            // Test 44
            // Clicking the Details button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Details"))).Click();

            // driver.FindElement(By.LinkText("Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Details button");
            test.Log(Status.Pass, "Test 44 Passed");
            extent.Flush();

            // Test 45
            // Clicking the Cancel Booking button
            driver.FindElement(By.Id("btncancelsessionbooking")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Cancel Booking button");
            test.Log(Status.Pass, "Test 45 Passed");
            extent.Flush();

            // Test 46
            // Clicking Yes on the Dialogue
            driver.FindElement(By.Id("YesNoDialogueYes")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking Yes on the Dialogue");
            test.Log(Status.Pass, "Test 46 Passed");
            extent.Flush();

            // Test 47
            // Clicking the finish button
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Finish"))).Click();

            // driver.FindElement(By.Id("Finish")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 47 Passed");
            extent.Flush();

            // Test 48
            // Selecting the SelectedOutcome_ID
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("SelectedOutcome_ID")));

            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Registration Successful");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedOutcome_ID");
            test.Log(Status.Pass, "Test 48 Passed");
            extent.Flush();

            // Test 49
            // Clicking the Finish button
            driver.FindElement(By.CssSelector(".cti")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 49 Passed");
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
