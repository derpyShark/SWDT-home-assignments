using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumHomeworkTests.PageObjects
{
    class ContactUsPage
    {
        public By EmailField { get => By.Name("user_email"); }
        public By UserPhoneField { get => By.Name("user_phone"); }
        public By FirstNameField { get => By.Name("user_first_name"); }
        public By LastNameButton { get => By.Name("user_last_name"); }
        public By UserCommentSelect { get => By.Name("user_comment_how_hear_about"); }
        public By GdprConsentCheckbox { get => By.Name("gdprConsent"); }

    }
}
