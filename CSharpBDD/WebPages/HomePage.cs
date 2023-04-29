using CSharpBDD.Mian;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace CSharpBDD.WebPages
{
    public  class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Test Yantra']")]
        private IWebElement TestYantra { get; set; }


        [FindsBy(How = How.XPath, Using = ("//p[.='Menu']"))]
        private IWebElement Menu { get; set; }

        [FindsBy(How = How.XPath, Using = ("//a[.='Home']"))]
        private IWebElement Home { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Projects']")]
        private IWebElement Projects { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Users']")]
        private IWebElement Users { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Settings']")]
        private IWebElement Settings { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Logout']")]
        private IWebElement Logout { get; set; }


       public  HomePage()
        {
            PageFactory.InitElements(Utility.GetDriver(), this);

        }


        public IWebElement getTestYantra()
        {
            return TestYantra;
        }

        public IWebElement getHome()
        {
            return Home;
        }

        public IWebElement getMenu()
        {
            return Menu;
        }

        public IWebElement getProjects()
        {
            return Projects;
        }

        public IWebElement getUsers()
        {
            return Users;
        }

        public IWebElement getSettings()
        {
            return Settings;
        }

        public IWebElement getLogOut()
        {
            return Logout;
        }

        public void LogOut()
        {
            Logout.Click();
            System.Console.WriteLine("--------LogOut-------");
        }
    }
}
