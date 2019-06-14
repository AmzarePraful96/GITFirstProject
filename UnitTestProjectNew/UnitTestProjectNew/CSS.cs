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
    public class CSS
    {
        [Test]
        public void CSS1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();

            //1
            IWebElement age = driver.FindElement(By.CssSelector("#calinputtable > tbody > tr:nth-child(1) > td:nth-child(1)"));
            Console.WriteLine("age:" + age.Text);

            //2
            IWebElement age1 = driver.FindElement(By.CssSelector("#cage"));
            Console.WriteLine("age1:" + age1.GetAttribute("value"));

            //3
            //IWebElement table = driver.FindElement(By.CssSelector("#content > table:nth-child(73)"));
            IWebElement table = driver.FindElement(By.CssSelector("td:nth-of-type(4)"));

            IList<IWebElement> rows = driver.FindElements(By.TagName("tr"));
            foreach (IWebElement element in rows)
            {
                IList<IWebElement> cols = element.FindElements(By.TagName("td"));
              
                foreach(IWebElement col in cols)
                {
                    Console.Write(col.Text + "\t");
                }

                Console.WriteLine("\n");
            }
            
        }
    }
}
