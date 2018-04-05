using NUnit.Framework;
using selenium;
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
        }

    }
}
