using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBDD.Mian
{
     class Utility
    {
        private static ThreadLocal<IWebDriver> driverTL = new ThreadLocal<IWebDriver>();
        private static ThreadLocal<ExcelUtilities> ExcelUtilitiesTL = new ThreadLocal<ExcelUtilities>();
        private static ThreadLocal<CShapUtilities> CShapUtilitiesTL = new ThreadLocal<CShapUtilities>();
        private static ThreadLocal<WebDriverUtilities> WebDriverUtilitiesTL = new ThreadLocal<WebDriverUtilities>();

        public static void SetDriver(IWebDriver driver)
        {
            driverTL.Value = driver;
        }
        public static IWebDriver GetDriver()
        {
            return driverTL.Value;
        }


        public static void SetExcelUtilities(ExcelUtilities excelUtilities)
        {
            ExcelUtilitiesTL.Value = excelUtilities;
        }

        public static ExcelUtilities GetExcelUtilities()
        {
            return ExcelUtilitiesTL.Value;
        }


        public static void SetCShapUtilities(CShapUtilities CShapUtilities)
        {
            CShapUtilitiesTL.Value = CShapUtilities;
        }
        public static CShapUtilities GetCShapUtilities()
        {
            return CShapUtilitiesTL.Value;
        }

        public static void SetWebDriverUtilities(WebDriverUtilities WebDriverUtilities)
        {
            WebDriverUtilitiesTL.Value = WebDriverUtilities;
        }

        public static WebDriverUtilities GetWebDriverUtilities()
        {
            return WebDriverUtilitiesTL.Value;
        }
    }
}
