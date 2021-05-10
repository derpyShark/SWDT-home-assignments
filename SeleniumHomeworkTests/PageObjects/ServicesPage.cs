using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumHomeworkTests.PageObjects
{
    class ServicesPage
    {
        public string JobListingPageLink { get => "https://www.epam.com/services"; }
        public By ConsultTileImage{ get => By.CssSelector("img[src*=Consult]"); }
        public By ConsultTileText { get => By.CssSelector("img[src*=Consult] ~ div[aria-hidden=true] p"); }
    }
}
