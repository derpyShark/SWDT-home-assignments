using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumHomeworkTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumHomeworkTests.Steps
{
    [Binding]
    class SearchSteps
    {
        private SearchPage _searchPage = new SearchPage();
        private IWebDriver driver = new ChromeDriver(System.IO.Directory.GetCurrentDirectory());

        [Given(@"I go to the search page")]
        public void GivenIGoToTheSearchPage()
        {
            driver.Url = _searchPage.SearchPageLink;
        }

        [When(@"I enter spaces in the searchbar")]
        public void WhenIEnterSpacesInTheSearchbar()
        {
            IWebElement search = driver.FindElement(_searchPage.SearchInput);
            search.SendKeys("       ");
            search.Submit();
        }

        [Then(@"no search is done")]
        public void ThenNoSearchIsDone()
        {
            IWebElement counter = driver.FindElement(_searchPage.SearchCounter);
            bool result = counter.GetAttribute("class").Contains("hidden");
            driver.Close();
            Assert.IsTrue(result, "test failed");
        }
    }
}
