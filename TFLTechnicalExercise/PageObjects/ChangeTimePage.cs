using OpenQA.Selenium;

public class ChangeTimePage
{
    private readonly IWebDriver driver;

    public ChangeTimePage(IWebDriver _driver)
    {
        driver = _driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null.");
    }

    public void ClickChangeTimeLink()
    {
        // Code to click on the "Change Time" link
    }

    public bool IsArrivingOptionDisplayed()
    {
        // Code to check if the "Arriving" option is displayed
        /* true if "Arriving" option is displayed, false otherwise */;
        return true;
    }

    public void PlanJourneyBasedOnArrivalTime()
    {
        // Code to plan a journey based on arrival time
    }
}
