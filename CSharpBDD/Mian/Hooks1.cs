using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using CSharpBDD.WebPages;
using NUnit.Framework;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;



namespace CSharpBDD.Mian
{
    [Binding]
   public  sealed class Hooks1 :PageInitializer
    {
      
        [BeforeScenario(Order =1)]
        
        public  void BeforeScenarioWithTag(ScenarioContext scenarioContext)
        {
            Utility.SetWebDriverUtilities(new WebDriverUtilities());
            Utility.SetExcelUtilities(new ExcelUtilities());
            Utility.SetCShapUtilities(new CShapUtilities());
            string browser = TestContext.Parameters.Get("Browser").ToString();
            Utility.GetWebDriverUtilities().OpenBrowserAndMaximizeAndImplicitWait(browser);
           
            ExtentReport. _scenario = ExtentReport. _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);

        }
        [BeforeScenario(Order = 2)]
        public void BeforeScenario()
        {
            string Url = TestContext.Parameters.Get("Url").ToString();
            string username = TestContext.Parameters.Get("username").ToString();
            string password = TestContext.Parameters.Get("password").ToString();


            Utility.GetWebDriverUtilities().Get(Url);

            logInPage = new LogInPage();
            logInPage.SetLogIn(username, password);

        }
        [AfterScenario]
        public void AfterScenario()
        {
            homePage = new HomePage();
            homePage.LogOut();
            Utility.GetWebDriverUtilities().Quit();
        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            Console.WriteLine("running Before TestRun..");
            ExtentReport. ExtentreportInit();
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("running After TestRun..");
            ExtentReport.ExtentReportTearDown();
        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("running Before Feature..");
            ExtentReport._feature = ExtentReport._extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("running After Feature..");
            
        }

        
        [BeforeStep]
        public void BeforeStep()
        {

        }
        [AfterStep]
        public void AfterStep( ScenarioContext scenarioContext)
        {
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;
           
            //when Scenario Passed
            if (scenarioContext.TestError == null)
            {
                //addScreenShot(driver, scenarioContext);
                if (stepType == "Given")
                {
                    ExtentReport. _scenario.CreateNode<Given>(stepName);
                }
                else if (stepType == "When")
                {
                    ExtentReport._scenario.CreateNode<When>(stepName);
                }
                else if (stepType == "And")
                {
                    ExtentReport._scenario.CreateNode<And>(stepName);
                }

                else if (stepType == "Then")
                {
                    ExtentReport._scenario.CreateNode<Then>(stepName);
                }
            }
            //when Scenario fail
            if (scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                {
                    ExtentReport._scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport. addScreenShot(Utility.GetDriver(), scenarioContext)).Build());
                }
                else if (stepType == "When")
                {
                    ExtentReport._scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenShot(Utility.GetDriver(), scenarioContext)).Build());
                }
                else if (stepType == "And")
                {
                    ExtentReport._scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenShot(Utility.GetDriver(), scenarioContext)).Build());
                }

                else if (stepType == "Then")
                {
                    ExtentReport._scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenShot(Utility.GetDriver(), scenarioContext)).Build());
                }
            }


        }
       
       
    }
}