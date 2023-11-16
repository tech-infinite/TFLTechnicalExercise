using OpenQA.Selenium;

public class ResultsPage
{
    private readonly IWebDriver driver;

    public ResultsPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public bool AreResultsDisplayed()
    {
        try
        {
            // Check if the key elements of journey results are present
            IWebElement fromElement = driver.FindElement(By.XPath("//div[@class='from-to-wrapper']//span[@class='label'][text()='From:']"));
            IWebElement toElement = driver.FindElement(By.XPath("//div[@class='from-to-wrapper']//span[@class='label'][text()='To:']"));
            IWebElement leavingElement = driver.FindElement(By.XPath("//div[@class='summary-row clearfix'][span[@class='label'][text()='Leaving:']]"));

            // If all key elements are found, consider the journey results displayed
            return fromElement.Displayed && toElement.Displayed && leavingElement.Displayed;
        }
        catch (NoSuchElementException)
        {
            // Handle the case where one or more key elements are not found
            return false;
        }
    }
}
