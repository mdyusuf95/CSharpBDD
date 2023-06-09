﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
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
        public static ExtentReports _extentReports=null;
        public static ExtentTest _feature=null;
        public static ExtentTest _scenario=null;

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

            string app = TestContext.Parameters.Get("application").ToString();
            string BaseUrl = TestContext.Parameters.Get("Url").ToString();
            string browsername = TestContext.Parameters.Get("Browser").ToString();
            string Author = TestContext.Parameters.Get("author").ToString();
            string os = TestContext.Parameters.Get("os").ToString();
            string TimeOut = TestContext.Parameters.Get("timeout").ToString();




            _extentReports.AddSystemInfo("Application", app);
            _extentReports.AddSystemInfo("BaseUrl", BaseUrl);
            _extentReports.AddSystemInfo("Browser", browsername);
            _extentReports.AddSystemInfo("TimeOut", TimeOut+" Sec");
            _extentReports.AddSystemInfo("OS And Version", os);
            _extentReports.AddSystemInfo("Author", Author);

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
