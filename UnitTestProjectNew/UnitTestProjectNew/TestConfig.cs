using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Configuration;
namespace UnitTestProjectNew
{
    [TestFixture]
    public class TestConfig
    {

        [Test]
        public void TestConfig1()
        {
            var ConnectionStringVar = ConfigurationManager.ConnectionStrings["DBConnectionString"];
            Console.WriteLine("DBConnection String:" + ConnectionStringVar);

            var con = ConfigurationManager.AppSettings["URL"];
            Console.WriteLine(con);
        }

    }
}
