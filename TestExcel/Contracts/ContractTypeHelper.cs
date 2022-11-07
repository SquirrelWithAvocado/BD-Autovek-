using System;
using System.Collections.Generic;
using System.Text;

namespace TestExcel.Contracts
{
    public class ContractTypeHelper
    {
        //public static ContractTypeHelper _contractTypeHelper;
        //// Делегат???
        //public ContractTypeHelper()
        //{
            
        //}

        public static void PridymatNazvanie()
        {
            var filePath = @"C:\Avtovek\test.xlsx";
            var data = "jjpfghjkp";

            var helper = new ScriptsExcel.ExcelHandler();
            var dataCommissionStruct = new ContractDataCommissionStruct();

            Console.WriteLine("Укажите ваш тип договора:\n" +
                "1) Печать документов для комиссии;\n" +
                "2) Печать документов для приема авто в Trade - IN\n" +
                "3) Перенести данные Покупателя в агентский договор для приёма на комиссию\n" +
                "4) Приём по прямому ДКП 3 экз без Покупателя");
            var choose = Console.ReadLine();



            switch (choose)
            {
                case "1":
                    helper.Open(filePath);
                    helper.WriteData(data, filePath, dataCommissionStruct);
                    helper.Save(filePath);
                break;
                //case "2":
                //    GetDataTRADEIN();
                //break;
                //case "3":
                //    GetDataBuyer();
                //break;
                //case "4":
                //    GetDataDKP();
                //break;
                default:
                    Console.WriteLine("Неверный ввод чсила!");
                break;
            }
        }
    }
}
