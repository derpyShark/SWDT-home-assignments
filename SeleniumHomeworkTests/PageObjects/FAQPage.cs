using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumHomeworkTests.PageObjects
{
    class FAQPage
    {
        public string FAQPageLink { get => "https://investors.epam.com/investors/faq"; }
        public By ExpansionButtons { get => By.ClassName("faqs-section__btn-toggle"); }
        public By ExpansionBlocks { get => By.ClassName("faqs-section__subject-link"); }
    }
}
