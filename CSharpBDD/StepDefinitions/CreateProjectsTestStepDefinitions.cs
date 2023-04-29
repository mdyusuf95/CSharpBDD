using BoDi;
using CSharpBDD.Mian;
using CSharpBDD.WebPages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CSharpBDD.StepDefinitions
{
    [Binding]
    public class CreateProjectsTestStepDefinitions:PageInitializer
    {
       
      
        [Given(@"click on Project button")]
        public void GivenClickOnProjectButton()
        {  
            homePage.getProjects().Click();
        }

        [When(@"click on addproject button")]
        public void WhenClickOnAddprojectButton()
        {  
            projectsPage.getProjectCreateBtn().Click(); 

        }

        [When(@"fill the all required deatails")]
        public void WhenFillTheAllRequiredDeatails()
        {
            projectsPage.SetProject("hamid", "2", "ganga", "closed");
        }

        [Then(@"project should display in project list")]
        public void ThenProjectShouldDisplayInProjectList()
        {
            Console.WriteLine("displayed");
        }
    }
}
