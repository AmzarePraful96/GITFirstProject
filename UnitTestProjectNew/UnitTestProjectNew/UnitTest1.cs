using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProjectNew
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            IWebDriver i = new ChromeDriver();
            i.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            i.Manage().Window.Maximize();
            IWebElement ie = i.FindElement(By.Id("cage"));
            ie.Clear();
            ie.SendKeys("100");
            Console.WriteLine("value change");

            //Pending work

            //locate element by class ,id,name recommended is id ,name ,class


        }
    }
}
