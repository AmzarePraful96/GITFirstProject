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
    class Time
    {

        [Test]
        public void WaitExampleTime1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement Componentmenu = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/a"));
            Componentmenu.Click();
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                //wait.Untill(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a")));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a")));

                IWebElement printerElement = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a"));
                Console.WriteLine(printerElement.Text);

               // Action action = new Action();
                Actions actions = new Actions(driver);
                actions.MoveToElement(printerElement).Click().Build().Perform();
                ////for monitor
                //IWebElement monitorElement = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[2]/a"));
                //Console.WriteLine(monitorElement.Text);
                ////Action action = new Action();
                //Actions action1 = new Actions(driver);
                //action1.MoveToElement(monitorElement).Click().Build().Perform();

            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

        }
    }
}
