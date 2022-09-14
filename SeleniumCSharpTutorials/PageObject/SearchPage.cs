using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace SeleniumCSharpTutorials.PageObject
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How=How.Id,Using = "search")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How=How.CssSelector,Using = "#search-icon-legacy")]
        public IWebElement SearchButton { get; set; }

        public ResultPage NavigateToResultPage()
        {
            SearchTextbox.SendKeys("selenium c# by bakkappa n");
            SearchButton.Click();
            return new ResultPage(driver);
        }
    }
}
