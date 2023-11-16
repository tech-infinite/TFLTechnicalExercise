using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLTechnicalExercise.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        public HomePage(IWebDriver driver) 
        {
           // driver = new ChromeDriver();
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null.");
        }   

        public void NavigateToPage() 
        {
            driver.Navigate().GoToUrl("https://tfl.gov.uk/");
        }



public void EnterValidLocation(string locationStart, string locationEnd)
    {
        IWebElement fromLocation = driver.FindElement(By.Id("InputFrom"));
        fromLocation.SendKeys(locationStart);

        // Use explicit wait for the "to" location element to be clickable
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement toLocation = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("InputTo")));

        // Ensure the element is visible before interacting with it
        wait.Until(ExpectedConditions.ElementIsVisible(By.Id("InputTo")));

        toLocation.SendKeys(locationEnd);
    }




        public void EnterInvalidLocations(string invalidLocation)
        {
            IWebElement locationInput = driver.FindElement(By.Id("locationInputId"));
            locationInput.SendKeys(invalidLocation);
            
        }

        public void PlanJourney()
        {
            IWebElement planJourneyButton = driver.FindElement(By.Id("plan-journey-button"));
            planJourneyButton.Click();
        }
    }
}
