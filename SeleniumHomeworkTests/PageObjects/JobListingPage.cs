using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumHomeworkTests.PageObjects
{
    class JobListingPage
    {
        public string JobListingPageLink { get => "https://www.epam.com/careers/job-listings"; }
        public By KeywordField { get => By.Id("new_form_job_search_1445745853_copy-keyword"); }
        public By ResultHeading { get => By.ClassName("search-result__heading"); }
        public By FindButton { get => By.ClassName("recruiting-search__submit"); }
    }
}
