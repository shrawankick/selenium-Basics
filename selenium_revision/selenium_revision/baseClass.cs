using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using NUnit.Framework.Interfaces;


namespace selenium
{
    class BaseClass
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            driver.Url = "https://www.google.co.in/";
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
