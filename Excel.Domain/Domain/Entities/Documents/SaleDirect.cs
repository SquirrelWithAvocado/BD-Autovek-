using System;
using Excel.Domain.Services;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace Excel.Domain.Entities.Documents
 {
     public class SaleDirect : Document
     {
         private string[] SheetsExcel { get; }
         private object[] DataSheet1 { get; }
         private object[] DataSheet2 { get; }
         
         private static readonly DateTime DateTime = new DateTime();

         public SaleDirect(string name, string surname, string patronymic, string placeOfBirth,
             string dateOfBirth, int indexDocument, List<Data> passport, List<Car> cars)
         {
             IndexDocument = indexDocument;
             
             DataSheet1 = new object[] { 
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
             DataSheet2 = new object[] { 
                 null, 
                 null, // Данные Договора
                 "Екатеринбург",
                 DateTime,
                 null, // Данные Покупателя
                 surname + " " + name[0] + "." + patronymic[0] + ".",
                 surname + " " + name + " " + patronymic,
                 dateOfBirth,
                 placeOfBirth,
                 null, // Паспортные данные
                 passport[0].Series,
                 passport[0].Number,
                 passport[0].WhereIssued,
                 passport[0].DateOfIssue,
                 passport[0].DivisionCode,
                 passport[0].PhoneNumber,
                 passport[0].Registration,
                 null,
                 "?",
                 "?"
             };
             SheetsExcel = new[] {"Данные Клиента Продавца и Авто","Данные Продажи"};
         }

         protected override void WriteTo(Sheets sheets)
         {
             Console.WriteLine("Into SaleDirect");

             try
             {
                 foreach (var sheet in SheetsExcel)
                 {
                     var worksheet = (Worksheet)sheets.Item[sheet];
                     if (sheet == "Данные Клиента Продавца и Авто")
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