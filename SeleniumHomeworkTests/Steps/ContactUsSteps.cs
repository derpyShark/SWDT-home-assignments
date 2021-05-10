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
        private Random random = new Random();
        

        [Given(@"I navigate to contact us page")]
        public void GivenINavigateToContactUsPage()
        {
            driver.Url = "https://www.epam.com/about/who-we-are/contact";
        }

        [When(@"I enter value with the length of '(.*)' in the '(.*)' field")]
        public void WhenIEnterValueWithTheLengthOfInTheField(string number, string field)
        {
            int num = int.Parse(number);
            FieldContainer container = GetFieldByName(field);
            container.InputField.SendKeys(CreateString(num));
            container.InputField.Submit();
        }

        [When(@"I enter '(.*)' in the '(.*)' field")]
        public void WhenIEnterInTheField(string value, string field)
        {
            FieldContainer container = GetFieldByName(field);
            container.InputField.SendKeys(value);
            container.InputField.Submit();
        }

        [Then(@"I can see under the '(.*)' field '(.*)' error message")]
        public void ThenICanSeeUnderTheFieldErrorMessage(string field, string message)
        {
            FieldContainer container = GetFieldByName(field);
            string result = container.ErrorLabel.Text;
            driver.Close();
            Assert.AreEqual(message, result, "Test failed");
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

        private string CreateString(int stringLength)
        {
            const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@$?_-";
            char[] chars = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedChars[random.Next(0, allowedChars.Length)];
            }

            return new string(chars);
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
