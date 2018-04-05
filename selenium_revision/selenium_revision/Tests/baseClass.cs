using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using NUnit.Framework.Interfaces;
using System.Collections.Specialized;
using System.Threading;

namespace selenium
{
    class BaseClass
    {
      private IWebDriver _driver;
        public IWebDriver driver {
            get {
                Thread.Sleep(500); //we are giving  time for element to load for slow webpages 
                return _driver;
            }
            set {
                _driver = value;
            }
        }

        [SetUp]
        public void Initialize()
        {
            InitializeDriver();
            Console.WriteLine("Test Started");
            
        }

        public void InitializeDriver()
        {
            var driverToTest = Convert.ToInt32(ConfigurationManager.AppSettings["driver"]);
            //ConfigurationManager can be added by reffrencing 
            //Right - click on references tab to add reference.
            //Click on Assemblies tab
            //Search for 'System.Configuration'
             //Click OK.


            if (driverToTest == 0)
            {
                driver = new FirefoxDriver();
            }
            else if (driverToTest == 1)
            {
                driver = new ChromeDriver();
            }
            else
            {
                driver = new InternetExplorerDriver(@"C:\Users\shraw\Downloads\IEDriverServer_Win32_3.3.0");
                //we have a link 
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }


        [TearDown]
        public void Close()
        {
            driver.Close();
            Console.WriteLine("Test completed");
        }
    }
}
