using Bytescout.Spreadsheet;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpBDD.Mian
{
    internal class ExcelUtilities
    {
        /// <summary>
        /// this method is usfull to get the data from perticular excel sheet 
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="SheetName"></param>
        /// <returns></returns>
        public Object[,] GetExcelSheetData(String FilePath, String SheetName)
        {

            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(FilePath);
            Worksheet s = spreadsheet.Workbook.Worksheets.ByName(SheetName);

            int row = s.NotEmptyRowMax;
            int col = s.NotEmptyColumnMax;
            Console.WriteLine(row);
            Console.WriteLine(col);
            Object[,] arr = new object[row, col];


            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= col; j++)
                {
                    String data = s.Cell(i, j).ToString();
                    arr[i, j] = data;
                }
            }

            return arr;

        }

        /// <summary>
        /// this is usefull to get perticular data from excel sheet
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="Sheetname"></param>
        /// <param name="Row"></param>
        /// <param name="Cell"></param>
        /// <returns></returns>
        public String GetExcelData(String FilePath, String Sheetname, int Row, int Cell)
        {

            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(FilePath);
            String data = spreadsheet.Workbook.Worksheets.ByName(Sheetname).Cell(Row, Cell).ToString();
            return data;

        }


        public static IEnumerable<object[]> GetExcelData()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(PathConstans.ExcelPath);
            var ws = spreadsheet.Workbook.Worksheets["Sheet1"];
            int row = ws.UsedRangeRowMax;
            for (int i = 1; i <= row; i++)
            {
                string CreatedBy = ws.Cell(i, 0).ToString();
                string Project = ws.Cell(i, 1).ToString();
                string Status = ws.Cell(i, 2).ToString();
                string teamSize = ws.Cell(i, 3).ToString();

                yield return new object[] { CreatedBy, Project, Status, teamSize };
            }

        }
       
    }
}
