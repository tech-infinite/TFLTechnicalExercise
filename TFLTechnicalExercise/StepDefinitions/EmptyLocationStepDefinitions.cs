using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TFLTechnicalExercise.PageObjects;

namespace TFLTechnicalExercise.StepDefinitions
{
    [Binding]
    public class EmptyLocationStepDefinitions
    {
        private readonly IWebDriver driver;
      
        public EmptyLocationStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"no locations are entered into the widget")]
        public void WhenNoLocationsAreEnteredIntoTheWidget()
        {
            var homePage = new HomePage(driver);
            homePage.PlanJourneyWithEmptyFields();
            

        }

        [Then(@"the user journey should not be planned")]
        public void ThenTheUserJourneyShouldNotBePlanned()
        {
            var homePage = new HomePage(driver);
            // Assuming CheckForError is a method in the HomePage class
            bool isErrorForFrom = homePage.CheckForError("InputFrom");
            bool isErrorForTo = homePage.CheckForError("InputTo");

            Assert.IsTrue(isErrorForFrom, "Error message not displayed for 'From' field");
            Assert.IsTrue(isErrorForTo, "Error message not displayed for 'To' field");
        }


    }
}
