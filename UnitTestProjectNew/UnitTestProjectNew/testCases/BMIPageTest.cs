using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace UnitTestProjectNew.testCases
{
    [TestFixture]
    public class BMIPageTest
    { 
        [Test]
        public void BMIPageTest1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/bmi-calculator.html");
            driver.Manage().Window.Maximize();


            pageObject.BMIPage bmipage = new pageObject.BMIPage(driver);
           String result= bmipage.EnterBMIDetails("23", "m", "5", "10", "135");

            Console.WriteLine(result);
        }


    }
}
