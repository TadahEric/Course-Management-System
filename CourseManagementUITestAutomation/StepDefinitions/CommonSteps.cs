﻿using System.IO;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using System;
using CourseManagementUITestAutomation.SetUp;

namespace CourseManagementUITestAutomation.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        Context _context;
        static ExtentTest feature;
        static ExtentTest scenario;
        static ExtentReports report;
        ScenarioContext _scenarioContext;

        public CommonSteps(Context context, ScenarioContext scenarioContext)
        {
            _context = context;
            _scenarioContext = scenarioContext;
        }

        [Given(@"that the CMS application is loaded")]
        [When(@"Course Management System application is loaded")]
        public void GivenThatTheCMSApplicationIsLoaded()
        {
            _context.LoadCMSApplication();
            scenario = feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
        }

        [BeforeTestRun]
        public static void ReportGenerator()
        {
            var testResultReport = new ExtentV3HtmlReporter(AppDomain.CurrentDomain.BaseDirectory + @"\TestResult.html");
            testResultReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            report = new ExtentReports();
            report.AttachReporter(testResultReport);
        }

        [AfterTestRun]
        public static void ReportCleaner()
        {
            report.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            feature = report.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [AfterStep]
        public void StepsInTheReport()
        {
            var typeOfStep = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            //Cater for a step that passed
            if (_scenarioContext.TestError == null)
            {
                if (typeOfStep.Equals("Given"))
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (typeOfStep.Equals("When"))
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (typeOfStep.Equals("Then"))
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                }
            }
            //Cater for a step that failed
            if (_scenarioContext.TestError != null)
            {
                if (typeOfStep.Equals("Given"))
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
                }
                else if (typeOfStep.Equals("When"))
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
                }
                else if (typeOfStep.Equals("Then"))
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
                }
            }
            //Cater for a step that has not been implemented
            if (_scenarioContext.ScenarioExecutionStatus.ToString().Equals("StepDefinitionPending"))
            {
                if (typeOfStep.Equals("Given"))
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                }
                else if (typeOfStep.Equals("When"))
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                }
                else if (typeOfStep.Equals("Then"))
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                }
            }
        }

        [AfterScenario]
        public void CloseApplicationUnderTest()
        {
            try
            {
                if (_scenarioContext.TestError != null)  //this condition will always be true when a test failed
                {
                    string scenarioName = _scenarioContext.ScenarioInfo.Title;
                    string directory = AppDomain.CurrentDomain.BaseDirectory + @"\Screenshots\";
                    _context.TakeScreenshotAtThePointOfTestFailure(directory, scenarioName);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                _context.ShutDownCMSApplication();
            }            
        }
    }
}
