using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace TestExcel.ScriptsExcel
{
    class ExcelHandler : IDisposable
    {
        private static Workbook _workbook;
        private static Sheets _sheets;
        private static Worksheet _worksheet;
        private static Application _excel;

        public ExcelHandler() // Constructor
        {
            _excel = new Application(); // создаем объект программы для этого подкл библу 
        }

        internal bool Open(string filePath)
        {
            try 
            {
                if (File.Exists(filePath)) // если файл существует
                {
                    _excel.DisplayAlerts = false;
                    _workbook = _excel.Workbooks.Open(filePath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                }
                else
                {
                    return false;
                    //_workbook = _excel.Workbooks.Add();
                    //_filePath = filePath;  //если файл существует, то filePath будет пустой 
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        internal bool WriteData(object data, string filePath, Contracts.ContractDataCommissionStruct commissionStruct)
        {
            try 
            {
                commissionStruct.documentSalesData = new Contracts.Documents.DocumentSalesData(); // убрать 
                _sheets = _workbook.Worksheets;
                _worksheet = (Worksheet)_sheets.get_Item($"{commissionStruct.documentSalesData.sheet1}");
                Excel.Range range = _worksheet.UsedRange;
                int colCount = range.Columns.Count;
                int rowCount = range.Rows.Count;
                for (int index = 7; index < 9; index++)
                {
                    _worksheet.Cells[commissionStruct.documentSalesData.row, commissionStruct.documentSalesData.column] = data;
                    //_worksheet.Cells[index + 1, 2] = data;
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        internal void Save(string filePath)
        {
            try
            {
                _workbook.SaveAs(filePath, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlExclusive,
                Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value);
                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void Dispose()
        {
            try
            {
                _workbook.Close(Missing.Value, Missing.Value, Missing.Value);
                _worksheet = null;
                _workbook = null;
                _excel.Quit();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}