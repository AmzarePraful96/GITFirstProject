using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace UnitTestProjectNew
{
    [TestFixture]
  public  class FindAllElementInPage
    {

        [Test]
        public void FindAllElementInPage1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();

            IWebElement iwe = driver.FindElement(By.XPath("//*[@name]"));

            Console.WriteLine("age:" + iwe.Text);
           

        }
    }
}
