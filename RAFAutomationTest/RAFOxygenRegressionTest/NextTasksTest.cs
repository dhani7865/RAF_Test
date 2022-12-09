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
    public class NextTasksTest
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

            string reportPath = projectPath + "TestReport\\RAF Next Tasks Button Test 21-11-2022.html";


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
        public void test_NextTasksTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Next Tasks Test").Info("Test Started");

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
            // Clicking on the Next Task Button
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(3) img"))).Click();

            // driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Next Tasks Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the show details button and waiting till the button has been clicked
            wait.Until(ExpectedConditions.ElementExists(By.LinkText("Show Details"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the show details button and waiting till the button has been clicked");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the Contact & Address button
            wait.Until(ExpectedConditions.ElementExists(By.LinkText("Contact & Address"))).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Contact & Address button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Clicking the Registrations button
            driver.FindElement(By.LinkText("Registrations")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Registrations button");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the Squadron Referrals button
            driver.FindElement(By.LinkText("Squadron Referrals")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Squadron Referrals button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the Tasks button
            driver.FindElement(By.LinkText("Tasks")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Tasks button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the Eckoh button
            driver.FindElement(By.LinkText("Eckoh")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Eckoh button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the Emails button
            driver.FindElement(By.LinkText("Emails")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Emails button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the Communications button
            driver.FindElement(By.LinkText("Communications")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Communications button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // test 11
            // Pressing the escape key to go off the pop up box
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Escape).Build().Perform();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Pressing the escape key to go off the pop up box");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the cancel button
            driver.FindElement(By.Id("btnCancel")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the cancel button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Clicking the Next Task button
            driver.FindElement(By.CssSelector("li:nth-child(3) span")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Next Task button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the dial button
            driver.FindElement(By.Id("btnDial")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the dial button");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Clicking the Abandon button
            driver.FindElement(By.Id("btnAbandon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Abandon button");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Clicking the Next Tasks button
            driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the  Next Tasks button");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Clicking the Dial button
            driver.FindElement(By.Id("btnDial")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Dial button");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the No Answer button
            driver.FindElement(By.Id("btnNoAnswer")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the No Answer button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the Next Task button
            driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Next task button");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Clicking the Dial button
            driver.FindElement(By.Id("btnDial")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Dial button");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Clicking the Answered button
            driver.FindElement(By.Id("btnAnswered")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Answered button");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the toast message 
            driver.FindElement(By.CssSelector(".toast > p")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Toast message");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Clicking the save contact button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("ContactEditSubmit"))).Click();

            // driver.FindElement(By.Id("ContactEditSubmit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save contact button");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the finish button
            wait.Until(ExpectedConditions.ElementExists(By.Id("Finish"))).Click();

            // driver.FindElement(By.CssSelector("#Finish > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Selecting the outcome ID
            var dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Remove Contact - Candidate Request");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the outcome ID");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Selecting the notes and enterring test
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the notes and enterring test");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Clicking the finish button
            driver.FindElement(By.CssSelector(".cti")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 27 Passed");
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
