using CSharpBDD.Mian;
using CSharpBDD.WebPages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CSharpBDD.StepDefinitions
{
    [Binding]
    public class ProjectPageTestStepDefinitions:PageInitializer
    {
        [ Order(2)]
        [Given(@"click projects module")]
        public void GivenClickProjectsModule()
        {
            homePage.getProjects().Click();
        }

        [Given(@"click on Add project button")]
        public void GivenClickOnAddProjectButton()
        {
            projectsPage.getProjectCreateBtn().Click();
        }

        [When(@"Project name text box should display")]
        public void WhenProjectNameTextBoxShouldDisplay()
        {
           Assert.IsTrue( projectsPage.getProjectnameBox().Displayed);
        }

        [When(@"Project manager")]
        public void WhenProjectManager()
        {
            Assert.IsTrue(projectsPage.getprojectManagerBox().Displayed);
        }

        [When(@"tean size text box should display")]
        public void WhenTeanSizeTextBoxShouldDisplay()
        {
            Assert.IsTrue(projectsPage.getteamSizeBox().Displayed);
        }

        [When(@"status drop down should display")]
        public void WhenStatusDropDownShouldDisplay()
        {
            Assert.IsTrue(projectsPage.getprojectStatusDropDown().Displayed);
        }

        [Then(@"submit button should display")]
        public void ThenSubmitButtonShouldDisplay()
        {
            Assert.IsTrue(projectsPage.getSubmitBtn().Displayed);
            Assert.IsTrue(projectsPage.getCacelBtn().Displayed);
            projectsPage.getCacelBtn().Click();
        }
    }
}
