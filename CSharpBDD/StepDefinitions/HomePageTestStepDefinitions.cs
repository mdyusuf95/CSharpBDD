using BoDi;
using CSharpBDD.Mian;
using CSharpBDD.WebPages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CSharpBDD.StepDefinitions
{
    [Binding]
    public class HomePageTestStepDefinitions:PageInitializer
    {

        
        [Then(@"all elements should displayed in home page"),Category("smoke")]
        [Order(1)]
        
        public void ThenAllElementsShouldDisplayedInHomePage()
        {
          
            
            Assert.IsTrue(homePage.getMenu().Displayed);
            Assert.IsTrue(homePage.getProjects().Displayed);
            Assert.IsTrue(homePage.getUsers().Displayed);
            Assert.IsTrue(homePage.getTestYantra().Displayed);
            
        }
    }
}
