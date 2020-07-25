using System.Collections.Generic;
using TechTalk.SpecFlow;
using TaskManagementAPITestAutomation.Model;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;
using TaskManagementAPITestAutomation.SetUp;
using NUnit.Framework;

namespace TaskManagementAPITestAutomation.StepDefinitions
{
    [Binding]
    public class ProjectSteps
    {
        Context context;
        DatabaseHelper databaseHelper;

        public ProjectSteps(Context _context, DatabaseHelper _databaseHelper)
        {
            context = _context;
            databaseHelper = _databaseHelper;
        }

        [Then(@"the following records must be retrieved from Projects table")]
        public void ThenTheFollowingRecordsMustBeRetrieved(Table table)
        {
            var expectedResult = table.CreateSet<ProjectModel>();
            var actualResult = JsonConvert.DeserializeObject<List<ProjectModel>>(context.content);
            Assert.IsTrue(ObjectComparer(expectedResult, actualResult));
        }

        //option 1 to validate Post method
        [Then(@"the following record should appear on the Projects table")]
        public void ThenTheFollowingRecordShouldAppearOnTheProjectsTable(Table table)
        {            
            var expectedResult = table.CreateSet<ProjectModel>();
            var actualResult = databaseHelper.RetrieveDataFromATable(Constants.retrieveRecordFromProjectTable);
            Assert.IsTrue(ObjectComparer(expectedResult, actualResult));            
        }

        //option 2 to validate Post method
        [Then(@"the Projects table should have (.*) on the Name column")]
        public void ThenTheProjectsTableShouldHaveMobileTestingOnTheNameColumn(string expectedResult)
        {
            Assert.IsTrue(expectedResult.Equals(databaseHelper.SelectNameFromProjectTable(Constants.retrieveNameColumnFromProjectTable)));
        }

        [Given(@"that TMS web services with resource (.*) is loaded for a POST call")]
        public void GivenThatTMSWebServicesIsLoadedForAPOSTCall(string resource)
        {
            databaseHelper.ClearOrPopulateATable(Constants.clearTable + resource);
            Dictionary<string, string> body = new Dictionary<string, string>();
            body.Add("Name", "Mobile Testing");
            context.PostMethod(resource, body);
        }

        [Given(@"that TMS web services with resource (.*) is loaded for a PUT call")]
        public void GivenThatTMSWebServicesIsLoadedForAPUTCall(string resource)
        {
            databaseHelper.ClearOrPopulateATable(Constants.clearTable + resource);
            databaseHelper.ClearOrPopulateATable(Constants.populateSingleProjectTRecord);
            string id = databaseHelper.SelectIdFromProjectTable(Constants.retrieveIdColumnFromProjectTable).ToString();
            Dictionary<string, string> body = new Dictionary<string, string>();
            body.Add("Id", id);
            body.Add("Name", "Cyber Security");
            //string newResource = resource+"/"+id;
            string newResource = $"{resource}/{id}";
            context.PutMethod(newResource, body);
        }

        [Given(@"that TMS web services with resource (.*) is loaded for a GET call")]
        public void GivenThatTMSWebServicesIsLoadedForAGETCall(string resource)
        {
            databaseHelper.ClearOrPopulateATable(Constants.clearTable + resource);
            databaseHelper.ClearOrPopulateATable(Constants.populateMultipleProjectRecords);
            context.GetMethod(resource);
        }

        [Given(@"that TMS web services with resource (.*) is loaded for a DELETE call")]
        public void GivenThatTMSWebServicesIsLoadedForADELETECall(string resource)
        {
            databaseHelper.ClearOrPopulateATable(Constants.clearTable + resource);
            databaseHelper.ClearOrPopulateATable(Constants.populateSingleProjectTRecord);
            string id = databaseHelper.SelectIdFromProjectTable(Constants.retrieveIdColumnFromProjectTable).ToString();
            string newResource = $"{resource}/{id}";
            context.DeleteMethod(newResource);
        }

        public bool ObjectComparer(object expectedObject, object actualObject)
        {
            var objectOne = JsonConvert.SerializeObject(expectedObject);
            var objectTwo = JsonConvert.SerializeObject(actualObject);
            return objectOne == objectTwo;
        }
    }
}
