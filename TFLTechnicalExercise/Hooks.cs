using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

[Binding]
public class Hooks
{
    private static IWebDriver ?driver;

    [BeforeScenario]
    public void BeforeScenario()
    {
        // Initialize the WebDriver before each scenario
        driver = new ChromeDriver();
        var objectContainer = ScenarioContext.Current.ScenarioContainer.Resolve<ObjectContainer>();
        objectContainer.RegisterInstanceAs(driver);
    }

    [AfterScenario]
    public void AfterScenario()
    {
        // Close the WebDriver after each scenario
        driver?.Quit();
    }
}
