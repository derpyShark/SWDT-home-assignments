using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumHomeworkTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumHomeworkTests.Steps
{
    [Binding]
    class ServicesSteps
    {
        private ServicesPage _servicesPage = new ServicesPage();
        private IWebDriver driver = new ChromeDriver(System.IO.Directory.GetCurrentDirectory());

        [Given(@"I go to the services page")]
        public void GivenIGoToTheServicesPage()
        {
            driver.Url = _servicesPage.JobListingPageLink;
            driver.Manage().Window.Maximize();
        }

        [When(@"I highlight consult")]
        public void WhenIHighlightConsult()
        {
            IWebElement image = driver.FindElement(_servicesPage.ConsultTileImage);
            Actions actions = new Actions(driver);
            actions.MoveToElement(image).Perform();
        }

        [Then(@"I can see the text within")]
        public void ThenICanSeeTheTextWithin()
        {
            IWebElement text = driver.FindElement(_servicesPage.ConsultTileText);
            string textWithin = text.Text;
            driver.Close();
            Assert.AreEqual("We harness the power of our integrated consulting talent, alongside our data expertise, to work out where we can provide value and address your unique needs.",
                textWithin, "test failed");
        }
    }
}
