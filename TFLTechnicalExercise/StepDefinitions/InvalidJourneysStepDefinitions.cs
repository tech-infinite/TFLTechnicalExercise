using System;
using TechTalk.SpecFlow;

namespace TFLTechnicalExercise.StepDefinitions
{
    [Binding]
    public class InvalidJourneysStepDefinitions
    {
        [When(@"invalid locations are entered into the widget")]
        public void WhenInvalidLocationsAreEnteredIntoTheWidget()
        {
            throw new PendingStepException();
        }
    }
}
