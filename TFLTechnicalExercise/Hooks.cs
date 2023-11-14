using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

[Binding]
public class Hooks
{
    private static IWebDriver driver;

    [BeforeScenario]
    public void BeforeScenario()
    {
        // Initialize the driver before each scenario
        driver = new ChromeDriver();
    }

    [AfterScenario]
    public void AfterScenario()
    {
        // Close the driver after each scenario
        driver.Quit();
    }

    public static IWebDriver GetDriver()
    {
        return driver;
    }
}
