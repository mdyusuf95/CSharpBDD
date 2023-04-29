using CSharpBDD.WebPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CSharpBDD.Mian
{
    [Binding]
    public class PageInitializer
    {
        public HomePage homePage;
        public LogInPage logInPage;
        public ProjectsPage projectsPage;

        [BeforeScenario]
        public  void InitialzeAllPages()
        {
           

            homePage = new HomePage();
            logInPage = new LogInPage();
            projectsPage = new ProjectsPage();
        }
    }
}
