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
    class ContactUsSteps
    {
        private ContactUsPage _contactUsPage = new ContactUsPage();
        private IWebDriver driver = new ChromeDriver(System.IO.Directory.GetCurrentDirectory());

        [Given(@"I am an Internet user navigating the https://www\.epam\.com/ website")]
        public void GivenIAmAnInternetUserNavigatingTheHttpsWww_Epam_ComWebsite()
        {
            driver.Url = "https://www.epam.com/about/who-we-are/contact";
        }

        [Given(@"I navigate to contact us page")]
        public void GivenINavigateToContactUsPage()
        {
            driver.Url = "https://www.epam.com/about/who-we-are/contact";
        }

        [When(@"I enter '(.*)' in the '(.*)' field")]
        public void WhenIEnterInTheField(string value, string field)
        {
            FieldContainer container = GetFieldByName(field);
            container.InputField.SendKeys(value);
        }

        [Then(@"I can see under the '(.*)' field '(.*)' error message")]
        public void ThenICanSeeUnderTheFieldErrorMessage(string field, string message)
        {
            FieldContainer container = GetFieldByName(field);
            Assert.AreEqual(message, container.ErrorLabel.Text, "Test failed");
        }

        private FieldContainer GetFieldByName(string name)
        {
            switch (name)
            {
                case "First Name":
                    return new FieldContainer()
                    {
                        InputField = driver.FindElement(_contactUsPage.FirstNameField),
                        ErrorLabel = driver.FindElement(_contactUsPage.FirstNameErrorLabel)
                    };
                case "Last Name":
                    return new FieldContainer()
                    {
                        InputField = driver.FindElement(_contactUsPage.LastNameField),
                        ErrorLabel = driver.FindElement(_contactUsPage.LastNameErrorLabel)
                    };
                case "Email":
                    return new FieldContainer()
                    {
                        InputField = driver.FindElement(_contactUsPage.EmailField),
                        ErrorLabel = driver.FindElement(_contactUsPage.EmailErrorLabel)
                    };
                case "Phone":
                    return new FieldContainer()
                    {
                        InputField = driver.FindElement(_contactUsPage.PhoneField),
                        ErrorLabel = driver.FindElement(_contactUsPage.PhoneErrorLabel)
                    };
            }
            return null;
        }
    }

    public class FieldContainer
    {
        public IWebElement InputField
        {
            get; set;
        }

        public IWebElement ErrorLabel
        {
            get; set;
        }
    }
}
