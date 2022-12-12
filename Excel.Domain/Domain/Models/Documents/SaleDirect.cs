using Excel.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Excel.Infrastructure;

namespace Excel.Domain.Models.Documents
{
    public class SaleDirect : Documents
    {
        private string[] Data { get; }
        private string[] Data2 { get; }
        private string[] Sheet1 { get; }
        private int MaxRow { get; }
        private int MaxRow2 { get; }

        // private Person _person;

        // public SaleDirect(Workbook workbook, Workbooks workbookTemporary, 
        //     Sheets sheets, Worksheet worksheet, Application excel) : 
        //     base(workbook, workbookTemporary, sheets, worksheet, excel)
        public SaleDirect()
        {
            Data = new[] { "data sale" };
            Data2 = new[] { "data2 sale" };
            Sheet1 = new[] { "Данные Клиента Продавца и Авто", "Zakrivashki" }; 
            MaxRow = 29;
            MaxRow2 = 19;

            // _person = new Person();
        }

        public override bool WriteTo()
        {
            try
            {
                Sheets = Workbook.Worksheets;
                foreach (var sheet in Sheet1)
                {
                    Worksheet = (Worksheet)Sheets.get_Item(sheet);
                    // if (_worksheet is null)
                    //     throw new CannotGetWorksheetException(sheets);
                    Microsoft.Office.Interop.Excel.Range range = Worksheet.UsedRange;
                    if (sheet == "Данные Клиента Продавца и Авто")
                    {
                        for (var row = 1; row <= MaxRow; row++)
                        {
                            if (row != 32) // заменить 32 создать объект
                                Worksheet.Cells[row, 2] = Data[0];
                        }
                    }
                    else
                    {
                        for (var row = 1; row <= MaxRow2; row++)
                        {
                            Worksheet.Cells[row, 2] = Data2[0];
                        }
                    }
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        // public override void Dispose()
        // {
        //     try
        //     {
        //         Console.WriteLine("Delete proc");
        //         Workbook.Close(true);
        //         Excel.Quit();
        //
        //         Marshal.ReleaseComObject(Workbook);
        //         Marshal.ReleaseComObject(WorkbookTemporary);
        //         Marshal.ReleaseComObject(Worksheet);
        //         Marshal.ReleaseComObject(Sheets);
        //         Marshal.ReleaseComObject(Excel);
        //         //_excel.Quit();
        //         //_workbook.Close(Missing.Value, Missing.Value, Missing.Value);
        //         //_worksheet = null;
        //         //_workbook = null;
        //         //GC.WaitForPendingFinalizers();
        //         //GC.Collect();
        //         //GC.WaitForPendingFinalizers();
        //         //GC.Collect();
        //     }
        //     catch (Exception ex) { Console.WriteLine(ex.Message); }
        // }
    }

    // public class CannotGetWorksheetException : Exception
    // {
    //     public CannotGetWorksheetException(Sheets sheets)
    //     {
    //         
    //     }
    // }
}
