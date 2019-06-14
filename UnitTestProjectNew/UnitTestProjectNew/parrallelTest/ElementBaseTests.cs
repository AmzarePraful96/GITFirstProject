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
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
namespace UnitTestProjectNew.parrallelTest
{
    [TestFixture]
    [Parallelizable]
   public class ElementBaseTests:TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase),"BrowserToRun")]
        public void VerifyDropDownCount(String browserName)
        {
            SetUp(browserName);
            driver.Url = "https://www.calculator.net/bmi-calculator.html";
            int DropDownCount = driver.FindElements(By.XPath("//select")).Count();
            Assert.AreEqual(0, DropDownCount);
            Console.WriteLine(DropDownCount);

        }
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRun")]
        public void VerifyTextBoxCount(String browserName)
        {
            SetUp(browserName);
            driver.Url = "https://www.calculator.net/bmi-calculator.html";
            int TextBoxCount = driver.FindElements(By.XPath("//input[@type='text']")).Count();
            Assert.AreEqual(6, TextBoxCount);
            Console.WriteLine(TextBoxCount);

        }
    }
}
