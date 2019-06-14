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
   public class PatternMatch
    {
        [Test]
        public void PatternMatch1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Perform Pattern start with C ");

            IList<IWebElement> startwithid = driver.FindElements(By.XPath("//*[starts-with(@id,'c')]"));
            foreach (IWebElement element in startwithid )
            {
                Console.WriteLine(element.GetAttribute("id"));
            }

            Console.WriteLine("Perform Pattern Contains with height ");

            IList<IWebElement> startwithcontains = driver.FindElements(By.XPath("//*[contains(@name,'height')]"));
            foreach (IWebElement element in startwithcontains)
            {
                Console.WriteLine(element.GetAttribute("name"));
            }

            /*  Console.WriteLine("Perform Pattern ends with Weight ");

              IList<IWebElement> startwithweight = driver.FindElements(By.XPath("//*[ends-with(@id,'weight')]"));
              foreach (IWebElement element in startwithweight)
              {
                  Console.WriteLine(element.GetAttribute("id"));
              }
              */

        }
    }
}
