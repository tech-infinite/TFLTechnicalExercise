using NUnit.Framework;
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

        public void ClickPlanJourney()
        {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                // Wait for the overlapping element to become invisible
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("stop-points-search-suggestion-1")));

                // Now click the "Plan my journey" button
                IWebElement planJourneyButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("plan-journey-button")));
                planJourneyButton.Click();
        }

        public bool IsFieldEmpty(string inputId)
        {
            try
            {
                // Find the input field element by Id
                IWebElement inputField = driver.FindElement(By.Id(inputId));

                // Check if the input field is empty
                return string.IsNullOrWhiteSpace(inputField.GetAttribute("value"));
            }
            catch (NoSuchElementException)
            {
                // Handle the case where the input field is not found
                Console.WriteLine($"Input field not found for {inputId}");
                return false; // Assuming it's not empty if the field is not found
            }
        }

        public void PlanJourneyWithEmptyFields()
        {
            // Check if both the "From" and "To" fields are empty
            bool isFromEmpty = IsFieldEmpty("InputFrom");
            bool isToEmpty = IsFieldEmpty("InputTo");

            // If both fields are empty, attempt to plan the journey
            if (isFromEmpty && isToEmpty)
            {
                // Click on the "Plan Journey" button
                IWebElement planJourneyButton = driver.FindElement(By.Id("planJourneyButtonId"));
                planJourneyButton.Click();

                // Check for the error messages for both "From" and "To" fields
                CheckForError("InputFrom");
                CheckForError("InputTo");
            }
        }

        public bool CheckForError(string inputId)
        {
            try
            {
                // Find the error element for the specified inputId
                IWebElement errorElement = driver.FindElement(By.CssSelector($"span[data-valmsg-for='{inputId}'] span"));

                // Check if the error message is present
                return errorElement.Displayed && errorElement.Text.Equals($"The {inputId} field is required.");
            }
            catch (NoSuchElementException)
            {
                // Handle the case where the error element is not found
                Console.WriteLine($"Error element not found for {inputId}");
                return false;
            }
        }





    }
}
