using NUnit.Framework;
using selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_revision.Tests
{
    class BasicTest : BaseClass
    {

        [Test]
        public void Test()
        {
            driver.Url = "https://www.google.co.in/";

            driver.FindElement(By.XPath("//*[@id='lst-ib']")).SendKeys("test");

            string inputvalue = driver.FindElement(By.XPath("//*[@id='lst-ib']")).Text;
            Assert.IsTrue(inputvalue.Contains("test"), inputvalue + " doesn't contains 'the Text you added .'");

            // //*[@id="lst-ib"
        }

    }
}
