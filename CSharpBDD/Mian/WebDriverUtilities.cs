using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBDD.Mian
{
     public class WebDriverUtilities
    {
        public IWebDriver driver;
        /// <summary>
        /// this is usefull to go to page perticular page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="Url"></param>
        public void GoToUrl(String Url)
        {
            Utility.GetDriver().Navigate().GoToUrl(Url);

        }

        /// <summary>
        ///  usefull for waite for findelement and find elememts
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="timeinseconds"></param>
        public void implicityWaites(int timeinseconds)
        {
            Utility.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeinseconds);

        }




        /// <summary>
        ///  this is usefull to accept the alert 
        /// </summary>
        /// <param name="driver"></param>
        public void AlertAcceptl(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();

        }

        /// <summary>
        /// this is usefull to Dismiss the alert 
        /// </summary>
        /// <param name="driver"></param>

        public static void AlertDissmiss()
        {
            Utility.GetDriver().SwitchTo().Alert().Dismiss();

        }

        /// <summary>
        /// this method is usefull for to select dropdowpOption by Visibletext
        /// </summary>
        /// <param name="element"></param>
        /// <param name="visbletext"></param>
        public void SelectElements(IWebElement element, String visbletext)
        {
            string VisibleText = visbletext.Trim();
            SelectElement s = new SelectElement(element);
            s.SelectByText(VisibleText);
        }

        /// <summary>
        ///  this method is usefull for to select dropdowpOption by index
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index"></param>
        public void SelectElements(IWebElement element, int index)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByIndex(index);
        }


        /// <summary>
        ///  this method is usefull for to select dropdowpOption by Value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="element"></param>
        public void SelectElements(String value, IWebElement element)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByValue(value);

        }

        /// <summary>
        ///  this method is usefull to swithto in to diff frames by using index value
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="index"></param>
        public void HandleFrames(IWebDriver driver, int index)
        {
            driver.SwitchTo().Frame(index);

        }

        /// <summary>
        /// this method is usefull to swithto in to diff frames by using frame element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public void HandleFrames(IWebDriver driver, IWebElement element)
        {
            driver.SwitchTo().Frame(element);

        }

        /// <summary>
        /// this method is usefull to Movethe mouse cursor to perticular element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public void MouseAction(IWebDriver driver, IWebElement element)
        {
            Actions a = new Actions(driver);
            a.MoveToElement(element);

        }

        /// <summary>
        /// this method is usefull to rigthClicking  on perticular element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        public void MouseAction(IWebElement element)
        {
            Actions a = new Actions(Utility.GetDriver());
            a.ContextClick(element);

        }

        /// <summary>
        /// this method is usefull to Swith to perticular window
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="window"></param>

        public void MouseAction(String window)
        {
            Utility.GetDriver().SwitchTo().Window(window);

        }

        /// <summary>
        ///  this method is usefull to handel disable elemntes setting the value of element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="value"></param>
        /// <param name="element"></param>
        public void HandleDisableElement(String value, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Utility.GetDriver();
            // js.ExecuteScript("arguments[0].value='" + value + "'", element);
            js.ExecuteScript("document.getElementsByName('projectName').value=" + value + "");

        }

        /// <summary>
        ///  this method is usefull to click on disabled element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public void JavaScripButtonClick(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Utility.GetDriver();
            js.ExecuteScript("arguments[0].scrollIntoView();", element);

        }

        public void ScrollUptoBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Utility.GetDriver();
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

        }
        /// <summary>
        /// this mehod is use open perticular browser and maximize it wait with implicitly wait
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="NameOFbrowser"></param>
        /// <returns></returns>
        public void OpenBrowserAndMaximizeAndImplicitWait(string NameOFbrowser)
        { 
             

            if (NameOFbrowser.Equals("chrome"))
            {
              

                driver = new ChromeDriver();
            }


            else if (NameOFbrowser.Equals("firefox"))
            {
              
                driver = new FirefoxDriver();
            }
          
            Utility.SetDriver(driver);
            Utility.GetDriver().Manage().Window.Maximize();
            Utility.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Console.WriteLine("   [-OpenBrowser-]");
            

        }

        /// <summary>
        /// this method is use to get get event firing webdriver
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
       /* public IWebDriver GetEventfiringWebDriver()
        {
            EventFiringWebDriver Driver = new CustomEventFiringHandler(Utility.GetDriver());
            driver = Driver;
            return driver;

        }*/
        /// <summary>
        /// thois method is use navigate perticular website
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="Url"></param>
        public void Get(string Url)
        {
            Utility.GetDriver().Navigate().GoToUrl(Url);
        }
        /// <summary>
        /// this method is use to create extentsreports and attach with html
        /// </summary>
        /// <param name="extent"></param>
        /// <returns></returns>
      /*  public ExtentReports CreateExtentReportAndAttachToHtml(ExtentReports extent)
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(PathConstans.ExtentReportfile);
            extent.AttachReporter(htmlReporter);
            return extent;

        }*/
        /// <summary>
        /// this methos is use to log test resultes into reports
        /// </summary>
        /// <param name="extent"></param>
        /// <param name="_testcontext"></param>
        /// <returns></returns>
        /*  public ExtentTest LogTest(ExtentReports extent, TestContext _testcontext, string methodName)
          {
              ExtentTest test = extent.CreateTest(methodName);
              if (_testcontext.CurrentTestOutcome == UnitTestOutcome.Passed)
              {



                  test.Log(Status.Pass, methodName);
              }

              return test;
          }*/
        /// <summary>
        /// this Method is use to dispose to driver
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="extent"></param>
        /* public void Quit(ExtentReports extent)
         {
             Utility.GetDriver().Quit();
             Utility.GetDriver().Dispose();
             extent.Flush();
             Console.WriteLine("   [-CloseBrowser-]");
         }*/
        public void Quit()
        {
            Utility.GetDriver().Quit();
            Utility.GetDriver().Dispose();
           
            Console.WriteLine("   [-CloseBrowser-]");
        }

        public void WaitUntilElementVisible(String Xpath)
        {
            WebDriverWait driverWait = new WebDriverWait(Utility.GetDriver(), TimeSpan.FromSeconds(20));
            driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(Xpath)));


        }
    }
}
