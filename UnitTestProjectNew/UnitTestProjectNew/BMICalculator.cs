using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
namespace UnitTestProjectNew
{
    [TestFixture]
    public class BMICalculator
    {

        IWebDriver driver = null;

        [SetUp]
        public void Launch()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
        }
    [Test]
        public void BMICalculator1()
        {             
               
                       
        //page title
        String title = driver.Title;
        Console.WriteLine("Title of Page" + title);
        Console.WriteLine("Current url of page" + driver.Url);

        driver.FindElement(By.LinkText("BMI")).Click();
        driver.Navigate().Forward();
        System.Threading.Thread.Sleep(1000);
        driver.Navigate().Refresh();

            IWebElement age=driver.FindElement(By.Id("cage"));
            age.Clear();
            age.SendKeys("23");

            IList<IWebElement> sexlist = driver.FindElements(By.Name("csex"));
            foreach(IWebElement sex in sexlist)
            {
                if(sex.GetAttribute("value").Equals("m"))
                {
                    if(!sex.Selected)
                    {
                        sex.Click();
                        break;
                    }
                }
            }
            
             

             IWebElement feet = driver.FindElement(By.Id("cheightfeet"));
            feet.Clear();
            feet.SendKeys("5");

            IWebElement inch = driver.FindElement(By.Id("cheightinch"));
            inch.Clear();
            inch.SendKeys("9");

            
            IWebElement pound = driver.FindElement(By.Id("cpound"));
            pound.Clear();
            pound.SendKeys("135");


            driver.FindElement(By.CssSelector("#content > div.leftinput > div.panel2 > table > tbody > tr > td > table:nth-child(4) > tbody > tr > td > input[type=image]:nth-child(2)")).Click();

           IWebElement  bmitext=driver.FindElement(By.XPath("//*[@id='content']/div[4]/div"));

            String bmi = bmitext.Text;
            Console.WriteLine(bmi);
            /*
                        string[] numbers = Regex.Split(bmi, @"\D+");

                        foreach (string value in numbers)
                        {
                            if (!string.IsNullOrEmpty(value))
                            {
                                double i = double.Parse(value);
                                Console.WriteLine("Number: {0}", i);
                            }
                        }

                */

            string[] strArr = null;
            int count = 0;
            char[] splitchar = { ' ' };
            strArr = bmi.Split(splitchar);
            double bmidouble = 0;
            for (count=0;count<=strArr.Length-1; count++)
            {
                if (count == 2)
                {
                    Console.WriteLine("BMI in String:" + strArr[count]);
                     bmidouble = double.Parse(strArr[count]);
                   
                }
            }
            Console.WriteLine("BMI in Double:" + bmidouble);

            //Expected Category

            string result = "";
            if(bmidouble<16)
            {
                Console.WriteLine("Your BMI in Severe Thinness");
                result = "Severe Thinness";
            }
            else if(bmidouble==16 &&  bmidouble == 17)
            {
                Console.WriteLine("Your BMI in Moderate Thinness");
                result = "Moderate Thinness";
            }
            else if (bmidouble>17 && bmidouble<=18.5)
            {
                Console.WriteLine("Your BMI in Mild Thinness");
                result = "Mild Thinness";
            }
            else if (bmidouble>18.5 && bmidouble<=25)
            {
                Console.WriteLine("Your BMI in Normal");
                result = "Normal";
            }
            else if (bmidouble>25 && bmidouble<=30)
            {
                Console.WriteLine("Your BMI in Overweight");
                result = "Overweight";
            }
            else if (bmidouble > 30 && bmidouble <= 35)
            {
                Console.WriteLine("Your BMI in Obese Class I");
                result = "Obese Class I";
            }
            else if (bmidouble > 35 && bmidouble <= 40)
            {
                Console.WriteLine("Your BMI in Obese Class II");
                result = "Obese Class II";
            }
            else
            {
                Console.WriteLine("Your BMI in Obese Class III");
                result = "Obese Class III";
            }


            CheckBMIFinal(bmidouble,result);

        }

        public void CheckBMIFinal(double bmidouble,string result)
        {
            
            IWebElement checkfinalbmi = driver.FindElement(By.XPath("//*[@id='content']/div[4]/div/font/b"));

            String bmicheck = checkfinalbmi.Text;
            Console.WriteLine(bmicheck);
            Assert.AreEqual(result, bmicheck);
            if (result == bmicheck)
            {
                Console.WriteLine("Test Pass");
            }
            else
            {
                Console.WriteLine("Test Not Pass");
            }
           
        }

        [TearDown]
        public void CloseLaunch()
        {
            Console.WriteLine("Browser Closed!!!");
            driver.Close();
            driver = null;
            
        }
    }
}


