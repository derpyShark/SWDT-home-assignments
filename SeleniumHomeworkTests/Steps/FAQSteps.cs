using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumHomeworkTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumHomeworkTests.Steps
{
    [Binding]
    class FAQSteps
    {
        private FAQPage _FAQPage = new FAQPage();
        private IWebDriver driver = new ChromeDriver(System.IO.Directory.GetCurrentDirectory());

        [Given(@"I navigate to the FAQ page")]
        public void GivenINavigateToTheFAQPage()
        {
            driver.Url = _FAQPage.FAQPageLink;
        }

        [When(@"I click on the expandable plus icons")]
        public void WhenIClickOnTheExpandablePlusIcons()
        {
            List<IWebElement> buttons = driver.FindElements(_FAQPage.ExpansionButtons).ToList();
            foreach (IWebElement button in buttons)
            {
                button.Click();
            }
        }

        [Then(@"I see that only one paragraph is expanded")]
        public void ThenISeeTheContentHiddenWithin()
        {
            List<IWebElement> blocks = driver.FindElements(_FAQPage.ExpansionBlocks).ToList();
            bool result = blocks.Select(b=> b.GetAttribute("class").Contains("item--expanded")).Single(b => b == true);
            driver.Close();
            Assert.IsTrue(result, "test failed");
        }
    }
}
