using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TFLTechnicalExercise.PageObjects;

namespace TFLTechnicalExercise.StepDefinitions
{
    [Binding]
    public class JourneyPlannerStepDefinitions
    {
        private IWebDriver? driver;
       

        [Given(@"the user is on the journey planner page")]
        public void GivenTheUserIsOnTheJourneyPlannerPage()
        {
            driver = Hooks.GetDriver();
            driver.Navigate().GoToUrl("https://tfl.gov.uk/");
        }

        [When(@"valid locations are entered into the widget")]
        public void WhenValidLocationsAreEnteredIntoTheWidget()
        {
            var homePage = new HomePage(driver);
            homePage.EnterValidLocation("Harrow", "Watford");
        }

        //[When(@"the user plans the journey")]
        //public void WhenTheUserPlansTheJourney()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the results should be displayed")]
        //public void ThenTheResultsShouldBeDisplayed()
        //{
        //    throw new PendingStepException();
        //}
    }
}
