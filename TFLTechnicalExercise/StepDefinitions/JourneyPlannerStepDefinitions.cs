using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TFLTechnicalExercise.PageObjects;

namespace TFLTechnicalExercise.StepDefinitions
{
    [Binding]
    public class JourneyPlannerStepDefinitions
    {
        private readonly IWebDriver driver;
        public JourneyPlannerStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;       
        }


        [Given(@"the user is on the journey planner page")]
        public void GivenTheUserIsOnTheJourneyPlannerPage()
        {
            //_driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://tfl.gov.uk/");
        }

        [When(@"valid locations are entered into the widget")]
        public void WhenValidLocationsAreEnteredIntoTheWidget()
        {
           var homePage = new HomePage(driver);
           homePage.EnterValidLocation("Harrow", "Watford");
        }

        [When(@"the user plans the journey")]
        public void WhenTheUserPlansTheJourney()
        {
            var homePage = new HomePage(driver);
            homePage.ClickPlanJourney();
        }

        [Then(@"the results should be displayed")]
        public void ThenTheResultsShouldBeDisplayed()
        {
            var results = new ResultsPage(driver);
            results.AreResultsDisplayed();
        }
    }
}
