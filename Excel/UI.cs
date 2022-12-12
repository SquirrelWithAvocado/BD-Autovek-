using System;
using Excel.Domain.Models;

namespace Excel.App
{
    public class UI
    {
        private enum Contracts
        {
            TradeIN,
            SaleDirect
        }
        private readonly AgencyPortfolio _agencyPortfolio;
        public UI()
        {
            _agencyPortfolio = new AgencyPortfolio();
        }
        
        public void Run()
        {
            while (true)
            {
                var choose = PromptMainMenuChoice();
                if (choose == "9")
                {
                    break;
                }
                _agencyPortfolio.CreateAgencyPortfolio(((Contracts)(Int32.Parse(choose)-1)).ToString());
                break;
            }
        }

        private string PromptMainMenuChoice()
        {
            Console.WriteLine("Укажите ваш тип договора:\n" +
                              "1) Для приема авто в Trade - IN\n" +
                              "2) Продажа по прямому договору;\n" +
                              "3) Перенести данные Покупателя в агентский договор для приёма на комиссию\n" +
                              "4) Приём по прямому ДКП 3 экз без Покупателя\n" +
                              "9) Выйти");
            return Console.ReadLine();
        }
    }
}
