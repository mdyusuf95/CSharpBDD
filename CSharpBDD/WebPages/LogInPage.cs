using CSharpBDD.Mian;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBDD.WebPages
{
   public  class LogInPage
    {
        [FindsBy(How = How.Id, Using = ("usernmae"))]
        private IWebElement UsernameBox { get; set; }

        [FindsBy(How = How.Id, Using = ("inputPassword"))]
        private IWebElement PasswordBox { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[.='Sign in']"))]
        private IWebElement SignInBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ("//h5[@class='card-title text-center']"))]
        private IWebElement SignInText { get; set; }

        [FindsBy(How = How.XPath, Using = ("//div[@class='card-body']"))]
        private IWebElement SignCardBody { get; set; }


        public LogInPage()
        {
            PageFactory.InitElements(Utility.GetDriver(), this);
        }


        public void SetLogIn(String username, String Password)
        {
            UsernameBox.SendKeys(username);
            PasswordBox.SendKeys(Password);
            SignInBtn.Click();
            Console.WriteLine("--------LogIN--------");

        }

        public IWebElement GetUsernameBox()
        {
            return UsernameBox;
        }
        public IWebElement GetPassWordBox()
        {
            return PasswordBox;
        }
        public IWebElement GetSignInBtn()
        {
            return SignInBtn;
        }
        public IWebElement GetSignInText()
        {
            return SignInText;
        }
        public IWebElement GetSignCardBody()
        {
            return SignCardBody;
        }
    }
}
