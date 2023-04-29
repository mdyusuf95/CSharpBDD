using CSharpBDD.Mian;
using CSharpBDD.WebPages;
using System;
using TechTalk.SpecFlow;

namespace CSharpBDD.StepDefinitions
{
    [Binding]
    public class CreateProjectsTestStepDefinitions:PageInitializer
    {
        [When(@"Create Multiple projects")]
        public void WhenCreateMultipleProjects(Table table)
        {
            foreach(var row in table.Rows)
            {
                string projectname = row["projectname"];
                string mangername = row["managername"];
                string teamsize = row["teamsize"];
                string status = row["status"];

                homePage.getProjects().Click();
                projectsPage.getProjectCreateBtn().Click();
                projectsPage.SetProject(projectname, teamsize, mangername, status);
            }
        }
    }
}
