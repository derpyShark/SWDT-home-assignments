using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumHomeworkTests.PageObjects
{
    public class ContactUsPage
    {
        public string ContactUsPageLink { get => "https://www.epam.com/about/who-we-are/contact"; }

        public By FirstNameField { get => By.Name("user_first_name"); }
        public By FirstNameErrorLabel { get => By.CssSelector("#_content_epam_en_about_who-we-are_contact_jcr_content_content-container_section_section-par_form_constructor_user_first_name-error .validation-text"); }

        public By LastNameField { get => By.Name("user_last_name"); }
        public By LastNameErrorLabel { get => By.CssSelector("#_content_epam_en_about_who-we-are_contact_jcr_content_content-container_section_section-par_form_constructor_user_last_name-error .validation-text"); }

        public By EmailField { get => By.Name("user_email"); }
        public By EmailErrorLabel { get => By.CssSelector("#_content_epam_en_about_who-we-are_contact_jcr_content_content-container_section_section-par_form_constructor_user_email-error .validation-text"); }

        public By PhoneField { get => By.Name("user_phone"); }
        public By PhoneErrorLabel { get => By.CssSelector("#_content_epam_en_about_who-we-are_contact_jcr_content_content-container_section_section-par_form_constructor_user_phone-error .validation-text"); }

        public By UserCommentSelect { get => By.Name("user_comment_how_hear_about"); }
        public By UserCommentErrorLabel { get => By.CssSelector("#_content_epam_en_about_who-we-are_contact_jcr_content_content-container_section_section-par_form_constructor_user_comment_how_hear_about-error .validation-text");}

        public By GdprConsentCheckbox { get => By.Name("gdprConsent"); }
        public By GdrpConsentErrorLable { get => By.Id("new_form_gdprConsent-error"); }

        public By SubmitButton { get => By.ClassName("button-ui"); }
    }
}
