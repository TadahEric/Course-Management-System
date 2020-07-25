using TechTalk.SpecFlow;
using TaskManagementAPITestAutomation.SetUp;
using NUnit.Framework;

namespace TaskManagementAPITestAutomation.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        Context context;      
        public CommonSteps(Context _context)
        {
            context = _context;            
        }        

        [Then(@"the status code must be equal to (.*)")]
        public void ThenTheStatusCodeMustBeOK(string expectedStatusCode)
        {
            //option 1
            Assert.IsTrue(expectedStatusCode.Equals(context.statusCode));

            //option 2
            Assert.IsTrue(expectedStatusCode.Equals(context.statusCode), $"Expected {expectedStatusCode} is not equal to Actual {context.statusCode}");

            //option 3
            Assert.IsTrue(expectedStatusCode.Equals(context.statusCode), $"Expected result is not equal to Actual result");

            //option 4
            Assert.AreEqual(expectedStatusCode, context.statusCode, $"Expected {expectedStatusCode} is not equal to Actual {context.statusCode}");
        }
    }
}
