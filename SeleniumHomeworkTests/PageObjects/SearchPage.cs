using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumHomeworkTests.PageObjects
{
    class SearchPage
    {
        public string SearchPageLink { get => "https://www.epam.com/search"; }
        public By SearchInput { get => By.ClassName("search-results__input"); }
        public By SearchCounter { get => By.ClassName("search-results__counter"); }
    }
}
