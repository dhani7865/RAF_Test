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
    public class ContactsTest
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

            string reportPath = projectPath + "TestReport\\RAF Contacts Button Test 21-11-2022.html";


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
            var test = extent.CreateTest("RAF - Contacts Test").Info("Test Started");

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
            // Clicking on the Contacts Button
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(4) img"))).Click();

            // driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Next Tasks Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Doing a contact search by enterring the firstname
            driver.FindElement(By.Id("ContactSearchViewModel_FirstName")).Click();
            driver.FindElement(By.Id("ContactSearchViewModel_FirstName")).SendKeys("second");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Doing a contact search by enterring the firstname");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the search button
            driver.FindElement(By.CssSelector("form > div:nth-child(8) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Clicking the view details button
            driver.FindElement(By.CssSelector("tr:nth-child(1) a:nth-child(2)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the view details button");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the Contact & Address button
            driver.FindElement(By.LinkText("Contact & Address")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Contact & Address button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the Registrations button
            driver.FindElement(By.LinkText("Registrations")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Registrations button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the Squadron Referrals button
            driver.FindElement(By.LinkText("Squadron Referrals")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Squadron Referrals button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the Tasks button
            driver.FindElement(By.LinkText("Tasks")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Tasks button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the Eckoh button
            driver.FindElement(By.LinkText("Eckoh")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Eckoh button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the Emails button
            driver.FindElement(By.LinkText("Emails")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Eckoh button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the Communications button
            driver.FindElement(By.LinkText("Communications")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Communications button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();


            // Test 13
            // Clicking the Back to Search button
            driver.FindElement(By.LinkText("Back to Search")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Search button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();


            // Test 14
            // Clicking the Home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Home button");
            test.Log(Status.Pass, "Test 14 Passed");
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
