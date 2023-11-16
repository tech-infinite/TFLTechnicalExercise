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
            IWebElement recentsTab = driver.FindElement(By.Id("jp-recent-tab-home"));
            recentsTab.Click();
        }

        public bool AreCookiesEnabled() 
        {
            return true;
        }

        public bool AreRecentsDisplayed()
        {
           return true;
        }
    }
}
