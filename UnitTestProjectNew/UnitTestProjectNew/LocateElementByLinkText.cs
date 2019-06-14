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
   public  class LocateElementByLinkText
    {
    [Test]
    public void LocateLinks()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();

            //page title
            String title = driver.Title;
            Console.WriteLine("Title of Page"+title);
            Console.WriteLine("Current url of page"+driver.Url);

            driver.FindElement(By.LinkText("BMI")).Click();
            driver.Navigate().Back();
            System.Threading.Thread.Sleep(1000);
            driver.Navigate().Forward();
            driver.FindElement(By.PartialLinkText("Watcher")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.Navigate().Refresh();
        }

    }
}
