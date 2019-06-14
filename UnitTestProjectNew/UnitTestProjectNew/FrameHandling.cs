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
    public class FrameHandling
    {

        [Test]
        public void FrameHandling1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://jqueryui.com/droppable/");
            driver.Manage().Window.Maximize();

            IWebElement frameElement = driver.FindElement(By.ClassName("demo-frame"));
            driver.SwitchTo().Frame(frameElement);

            System.Threading.Thread.Sleep(2000);

            IWebElement dragElement = driver.FindElement(By.Id("draggable"));

            IWebElement dropElement = driver.FindElement(By.Id("droppable"));

            Actions action = new Actions(driver);
            action.DragAndDrop(dragElement, dropElement).Perform();
            if(dropElement.Text.Equals("Dropped!"))
            {
                Console.WriteLine("Drag n Drop Succesfully");
            }
            else
            {
                Console.WriteLine("Drag n Drop Failed");
            }

        }
    }
}
