using CSharpBDD.Mian;
using System.Linq.Expressions;
using TechTalk.SpecFlow;


namespace CSharpBDD.StepDefinitions
{
    [Binding]
    public class CreateProjectsTestStepDefinitions:PageInitializer
    {
        [When(@"Create Multiple projects")]
        public void WhenCreateMultipleProjects(Table table)
        {
        again:
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
