using CSharpBDD.Mian;
using NUnit.Framework;
using System.Linq.Expressions;
using TechTalk.SpecFlow;


namespace CSharpBDD.StepDefinitions
{
    [Binding]
    public class CreateProjectsTestStepDefinitions:PageInitializer
    {
        [Order(3)]
        [When(@"Create Multiple projects")]
        public void WhenCreateMultipleProjects(Table table)
        {
        
            foreach (var row in table.Rows)
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
