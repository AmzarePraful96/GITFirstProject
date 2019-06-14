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
    public class ElementBaseTest2:TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRun")]
        public void VerifyRadioButton(String browserName)
        {
            SetUp(browserName);
            driver.Url = "https://www.calculator.net/bmi-calculator.html";
            int RadioButtonCount = driver.FindElements(By.XPath("//input[@type='radio']")).Count();
            Assert.AreEqual(2, RadioButtonCount);
            Console.WriteLine(RadioButtonCount);

        }
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRun")]
        public void VerifyCountLinks(String browserName)
        {
            SetUp(browserName);
            driver.Url = "https://www.calculator.net/bmi-calculator.html";
            int LinkCount = driver.FindElements(By.XPath("//a")).Count();
            Assert.AreEqual(LinkCount, 32);
            Console.WriteLine(LinkCount);

        }

    }
}
