using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumHomeworkTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumHomeworkTests.Steps
{
    [Binding]
    class JobListingSteps
    {
        private JobListingPage _jobListingPage = new JobListingPage();
        private IWebDriver driver = new ChromeDriver(System.IO.Directory.GetCurrentDirectory());

        [Given(@"I go to the job listing page")]
        public void GivenIGoToTheJobListingPage()
        {
            driver.Url = _jobListingPage.JobListingPageLink;
        }

        [When(@"I enter into the keyword input bar '(.*)'")]
        public void WhenIEnterIntoTheKeywordInputBar(string value)
        {
            IWebElement field = driver.FindElement(_jobListingPage.KeywordField);
            field.SendKeys(value);
        }

        [When(@"I click on the Find button")]
        public void WhenIClickOnTheFindButton()
        {
            IWebElement button = driver.FindElement(_jobListingPage.FindButton);
            button.Click();
        }

        [Then(@"I see the vacancies for this profession")]
        public void ThenISeeTheVacanciesForThisProfession()
        {
            IWebElement resultHeading = driver.FindElement(_jobListingPage.ResultHeading);
            bool result = resultHeading.Text.Contains("WE FOUND");
            driver.Close();
            Assert.IsTrue(result, "Test failed");
        }
    }
}
