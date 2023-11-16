using System;
using TechTalk.SpecFlow;

namespace TFLTechnicalExercise.StepDefinitions
{
    [Binding]
    public class RecentJourneysStepDefinitions
    {
        [Given(@"all cookies are enabled")]
        public void GivenAllCookiesAreEnabled()
        {
            throw new PendingStepException();
        }

        [When(@"the user plans a journey")]
        public void WhenTheUserPlansAJourney()
        {
            throw new PendingStepException();
        }

        [When(@"navigates to the ""([^""]*)"" tab")]
        public void WhenNavigatesToTheTab(string recents)
        {
            throw new PendingStepException();
        }

        [Then(@"a list of recently planned journeys should be displayed")]
        public void ThenAListOfRecentlyPlannedJourneysShouldBeDisplayed()
        {
            throw new PendingStepException();
        }
    }
}
