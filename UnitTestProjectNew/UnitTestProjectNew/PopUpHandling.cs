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
  public   class PopUpHandling
    {
        [Test]
        public void PopUpHandling1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //for alert
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("alert('This is information box');");
            System.Threading.Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            String alertMsg = alert.Text;
            alert.Accept();//click on btn
            if(alertMsg.Equals("This is information box"))
            {
                Console.WriteLine("alert match found");
            }
            else
            {
                Console.WriteLine("alert match not found");
            }
            
            //for confirm box
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js.ExecuteScript("confirm('This is Confirm box');");
            System.Threading.Thread.Sleep(2000);
            IAlert alert1 = driver.SwitchTo().Alert();
            String alertMsg1 = alert1.Text;
            alert1.Dismiss();//click on btn
            if (alertMsg1.Equals("This is Confirm box"))
            {
                Console.WriteLine("confirm match found");
            }
            else
            {
                Console.WriteLine("confirm match not found");
            }
            //alert1.Dismiss();

        }

    }
    }
