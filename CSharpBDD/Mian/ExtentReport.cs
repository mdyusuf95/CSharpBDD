using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CSharpBDD.Mian
{
    public  class ExtentReport
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static string dir = AppDomain.CurrentDomain.BaseDirectory;
        public static string testResultPath = dir.Replace("bin\\Debug\\net6.0", "TestReports");

        public static void ExtentreportInit()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(testResultPath);
            htmlReporter.Config.ReportName = "Automation Status Report";
            htmlReporter.Config.DocumentTitle = "Automation Status Report";
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Start();

            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
            _extentReports.AddSystemInfo("Application", " vtiger");
            _extentReports.AddSystemInfo("Browser", "Chrome");
            _extentReports.AddSystemInfo("OS", "Windows");

        }
        public static void ExtentReportTearDown()
        {
            _extentReports.Flush();
        }

        public static string addScreenShot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takescreenshot = (ITakesScreenshot)Utility.GetDriver();
            Screenshot Screenshot = takescreenshot.GetScreenshot();
            string screenshotloc = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + ".png");
            Screenshot.SaveAsFile(screenshotloc, ScreenshotImageFormat.Png);
            return screenshotloc;
        }

    }
}
