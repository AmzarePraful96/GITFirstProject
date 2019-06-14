using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectNew
{
    [TestFixture]
   public class Dropdown
    {
        [Test]
        public void Dropdown1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Drop Down List ");

            IWebElement activityid = driver.FindElement(By.Id("cactivity"));

            //SelectElement select = new SelectElement(activityid);
            //select.SelectByIndex(0);
            //Console.WriteLine("Current value changed by index to basel" + select.SelectOption.Text);
            //System.Threading.Thread.Sleep(2000);
            //select.SelectByValue("1.55");
            //System.Threading.Thread.Sleep(2000);
            //Console.WriteLine("Current value changed by index to dropdown" + select.SelectOption.Text);


        }
    }
}
