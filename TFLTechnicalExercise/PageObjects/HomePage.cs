using OpenQA.Selenium;
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
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null.");
        }   

        public void NavigateToPage() 
        {
            driver.Navigate().GoToUrl("https://tfl.gov.uk/");
        }

        public void EnterValidLocation(string locationStart, string locationEnd) 
        {
            // //*[@id="search-filter-form-0"]/div/div/span
            IWebElement fromLocation = driver.FindElement(By.Id("InputFrom"));
            fromLocation.SendKeys(locationStart);

            IWebElement toLocation = driver.FindElement(By.Id(""));
            toLocation.SendKeys(locationEnd);

            
        }

        public void EnterInvalidLocation(string invalidLocation) 
        {

        }
    }
}
