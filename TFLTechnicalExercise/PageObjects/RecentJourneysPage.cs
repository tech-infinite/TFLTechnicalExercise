using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLTechnicalExercise.PageObjects
{
    public class RecentJourneysPage
    {
        private readonly IWebDriver driver;

        public RecentJourneysPage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null.");
        }

        public void NavigateToRecentsTab()
        {
            // Code to navigate to the "Recents" tab
        }

        public bool AreRecentsDisplayed()
        {
            // Code to check if the list of recently planned journeys is displayed
           /* true if recents are displayed, false otherwise */
            return true;
        }
    }
}
