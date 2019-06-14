using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary12June2019;
using NUnit.Framework;


namespace UnitTestProjectNew
{[TestFixture]
    public class CalculateNew
    {
        [Test]
        public void TestAddition()
        {
            Calculator c = new Calculator();
            c.add(10, 20);
            int result = c.output();
            Console.WriteLine("sum of 2 nos:" + c.output());
            Assert.AreEqual(30, result);

        }
        [Test]
        public void TestDivision()
        {
            Calculator c = new Calculator();
            c.divide(200, 20);
            int result = c.output();
            Console.WriteLine("sum of 2 no:" + c.output());
            Assert.AreEqual(10, result);
        }

    }
}
