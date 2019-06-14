using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary12June2019;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.PageObjects;
namespace UnitTestProjectNew.pageObject
{
   
   public  class BMIPage
    {
        IWebDriver driver;     

        public BMIPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

 
        [FindsBy(How = How.Id, Using = "cage")]
        private IWebElement ageTextBox;

        [FindsBy(How = How.Name, Using = "csex")]
        private IList<IWebElement> sexList;

        [FindsBy(How = How.XPath, Using = "//*[@name='cheightfeet']")]
        private IWebElement heightFeetTextBox;

        [FindsBy(How = How.XPath, Using = "//*[@name='cheightinch']")]
        private IWebElement heightInchTextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='cpound']")]
        private IWebElement weightTextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[4]/div[2]/table/tbody/tr/td/table[4]/tbody/tr/td/input[2]")]
        private IWebElement calbutton;

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[4]/div/b")]
        private IWebElement bmi;

        public String EnterBMIDetails(String age,String sex,String heightfeet, String heightinch, String weight)
        {
            ageTextBox.Clear();
            ageTextBox.SendKeys(age);
            sexList.Clear();

           if (sexList.Count>0)
            {
                foreach (IWebElement sexElement in sexList)
                {
                    if (sexElement.GetAttribute("value").Equals(sex))
                    {
                        if (!sexElement.Selected)
                        {
                            sexElement.Click();
                            break;
                        }
                    }
                }
            }
           

            heightFeetTextBox.Clear();
            heightFeetTextBox.SendKeys(heightfeet);

            heightInchTextBox.Clear();
            heightInchTextBox.SendKeys(heightinch);

            weightTextBox.Clear();
            weightTextBox.SendKeys(weight);

            calbutton.Click();

           String result= bmi.Text;
            return result;
        }

    }
}
