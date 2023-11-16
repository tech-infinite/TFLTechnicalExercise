using System;
using TechTalk.SpecFlow;

namespace TFLTechnicalExercise.StepDefinitions
{
    [Binding]
    public class ChangeTimeStepDefinitions
    {
        [When(@"the user clicks on the ""([^""]*)"" link")]
        public void WhenTheUserClicksOnTheLink(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the ""([^""]*)"" option should be displayed")]
        public void ThenTheOptionShouldBeDisplayed(string arriving)
        {
            throw new PendingStepException();
        }

        [Then(@"the user plans a journey based on arrival time")]
        public void ThenTheUserPlansAJourneyBasedOnArrivalTime()
        {
            throw new PendingStepException();
        }
    }
}
