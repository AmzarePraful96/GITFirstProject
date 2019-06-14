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
namespace UnitTestProjectNew
{
    [TestFixture]
   public  class WindowsNavigation
    {
        [Test]
        public void WindowsNavigation1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.online.citibank.co.in/products-services/online-services/internet-banking.htm");
            driver.Manage().Window.Maximize();


            String parentWindowID = driver.CurrentWindowHandle;
            Console.WriteLine("ParentId :" + parentWindowID);

            IWebElement login = driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[2]/a"));
            login.Click();
            IList<String> winids = driver.WindowHandles;
            Console.WriteLine("Current Number of Open window:" + winids);
            String mainWindowId=null;
            String subWindowId=null;
            for(int i=0;i<winids.Count;i++)
            {
                mainWindowId = winids[0];
                subWindowId = winids[1];

            }
            Console.WriteLine("MainWindowId:" + mainWindowId);
            Console.WriteLine("SubWindowId:" + subWindowId);
            driver.SwitchTo().Window(subWindowId);
            driver.FindElement(By.XPath("//*[@id='User_Id']")).SendKeys("selenium");
            System.Threading.Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(mainWindowId);
            driver.FindElement(By.Id("topMnuinsurance")).Click();

        }
    }
}
