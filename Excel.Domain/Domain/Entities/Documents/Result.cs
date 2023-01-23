using System;
using Excel.Domain.Services;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace Excel.Domain.Entities.Documents
{
    public class Result : Document
    {
        private string[] SheetsExcel { get; }
        private object[] DataSheet1 { get; }
        private object[] DataSheet2 { get; }
        
        private static readonly DateTime DateTime = new DateTime();

        public Result(string name, string surname, string patronymic, string placeOfBirth,
            string dateOfBirth, int indexDocument, List<Data> passport, List<Car> cars)
        {
            IndexDocument = indexDocument;
            
            DataSheet1 = new object[]
            {
                null,
                null, // Данные о продаже
                "Екатеринбуог",
                indexDocument,
                DateTime,
                surname + " " + name + " " + patronymic,
                "?",
                "?",
                "?",
                "?"
            };
            
            DataSheet2 = new object[] { 
                null, 
                null, // Данные Агентского Договора не сделал
                "Екатеринбург", 
                indexDocument,
                DateTime,
                null, // Данные Клиента / Продавца
                surname + " " + name[0] + "." + patronymic[0] + ".",
                surname + " " + name + " " + patronymic,
                dateOfBirth,
                placeOfBirth,
                null, // Паспортные Данные
                passport[0].Series,
                passport[0].Number,
                passport[0].WhereIssued,
                passport[0].DateOfIssue,
                passport[0].DivisionCode,
                passport[0].PhoneNumber,
                passport[0].Registration,
                null, // Данные Автомобиля
                cars[0].VIN, 
                cars[0].Model,
                cars[0].TypeCar,
                cars[0].CategoryCar,
                cars[0].YearManufacture,
                cars[0].Chassis,
                cars[0].Cabin,
                cars[0].ColorCabin,
                cars[0].PassportCar,
                cars[0].Mileage,
                null, // Стоимость автомобиля по Агентскому договору
                "?",
                "?",
                null, // Данные для выставления счёта
                "?", 
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?"
            };
            SheetsExcel = new[] {"Закрывашки", "Данные Клиента Продавца и Авто"};
    }

        protected override void WriteTo(Sheets sheets)
        {
            Console.WriteLine("Into Result");

            try
            {
                foreach (var sheet in SheetsExcel)
                {
                    var worksheet = (Worksheet)sheets.Item[sheet];
                    if (sheet == "Закрывашки")
                    {
                        try
                        { 
                            for (var row = 1; row < DataSheet1.Length - 1; row++)
                            {
                                if (DataSheet1[row] != null) 
                                    worksheet.Cells[row, 2] = DataSheet1[row];
                            } 
                        }
                        catch (NullReferenceException e) { throw new Infrastructure.NullDataException(e); }
                    }
                    else
                    {
                        try
                        {
                            for (var row = 1; row < DataSheet2.Length - 1; row++)
                            {
                                if (DataSheet1[row] != null)   
                                    worksheet.Cells[row, 2] = DataSheet2[row];
                            }
                        }
                        catch (NullReferenceException e) { throw new Infrastructure.NullDataException(e); }
                    }
                }
            }
            catch (NullReferenceException e) { throw new Infrastructure.NullSheetException(e); }
        }
    }
}