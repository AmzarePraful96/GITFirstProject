using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.CSharp;
using NUnit.Framework;

using Excel = Microsoft.Office.Interop.Excel;
namespace UnitTestProjectNew
{[TestFixture]
   public  class ExcelRead
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range xlRange;

        [Test]
        public void ExcelRead1()
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open("C:/Users/CTEA/Documents/Visual Studio 2015/Projects/40005130/UnitTestProjectNew/UnitTestProjectNew/testData/bmidata.xlsx");
            xlWorkSheet = xlWorkBook.Worksheets[1];
            xlRange = xlWorkSheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int row = 1; row <= rowCount; row++)
            {
                for (int col = 1; col <= colCount; col++)
                {
                    Console.Write(xlRange.Cells[row, col].Value2.ToString()+"\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
