using NUnit.Framework;
using SeleniumCSharpTutorials.BaseClass;
using SeleniumCSharpTutorials.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var searchpage=new SearchPage(driver);
            var resultpage=searchpage.NavigateToResultPage();
            var channelpage=resultpage.NavigateToChannel();
            String actualChannelName=channelpage.getChannelName();
            String expectedChannelName = "Selenium Java Tutorials - Bakkappa N";
            Assert.IsTrue(actualChannelName.Equals(expectedChannelName));
            Thread.Sleep(5000);
        }

    }
}
