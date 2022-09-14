using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials.PageObject
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Selenium Java TestNG Tutorials - Bakkappa N")]
        public IWebElement ChannelNameLinkText { get; set; }

        public ChannelPage NavigateToChannel()
        {
            Thread.Sleep(3000);
            ChannelNameLinkText.Click();
            return new ChannelPage(driver);
        }
    }
}
