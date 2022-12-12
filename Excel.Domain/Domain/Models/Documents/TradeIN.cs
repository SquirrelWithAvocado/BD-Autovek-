using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Excel.Domain.Models.Documents
{
    public class TradeIN : Documents
    {
        private string[] Data { get; }
        private string Sheet1 { get; }
        private int MaxRow { get; }

        public TradeIN()
        {
            Data = new[] { "123" };
            Sheet1 = "Данные Клиента Продавца и Авто"; 
            MaxRow = 45;
        }

        public override bool WriteTo()
        {
            try
            {
                Sheets = Workbook.Worksheets;
                Worksheet = (Worksheet)Sheets.get_Item(Sheet1);
                // Microsoft.Office.Interop.Excel.Range range = Worksheet.UsedRange;
                for (var row = 1; row <= MaxRow; row++)
                {
                    if (row != 32)
                        Worksheet.Cells[row, 2] = Data[0];

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
        //         Workbook.Close(Missing.Value, Missing.Value, Missing.Value);
        //         Worksheet = null;
        //         Workbook = null;
        //         Excel.Quit();
        //         GC.WaitForPendingFinalizers();
        //         GC.Collect();
        //         GC.WaitForPendingFinalizers();
        //         GC.Collect();
        //     }
        //     catch (Exception ex) { Console.WriteLine(ex.Message); }
        // }
        //public продажа/покупка по прямой договор: до 29 заполняется и заполняются данные продажи до 19 и печать 3 экз
        // прием по прямому и ставим на комиссию: ДКП прямой полностью, ДКП прямой прием (при комиссии) (м б с комис может без)
        // закрывашки: закрывашки
        // трейд ин с пробегом: ДКП прямой, данные продажи,
    }
}
