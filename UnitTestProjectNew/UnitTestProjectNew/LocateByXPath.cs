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
    public class LocateByXPath
    {
        [Test]
        public void LocateByXPath1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();

            IWebElement iwe = driver.FindElement(By.XPath("//*[@id='calinputtable']/tbody/tr[1]/td[1]"));
            
            Console.WriteLine("age:" + iwe.Text);
            IWebElement iwe1 = driver.FindElement(By.XPath("//*[@id='cage']"));        
            Console.WriteLine("age:" + iwe1.GetAttribute("value"));
            
        }

    }
}
