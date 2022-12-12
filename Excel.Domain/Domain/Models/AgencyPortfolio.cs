using System;
using System.Collections.Generic;
using Excel.Domain.Models.Documents;
using Excel.Infrastructure;
using System.IO;

namespace Excel.Domain.Models
{
    public class AgencyPortfolio
    {
        private readonly Person _person;
        private string PathRootFolder { get; }
        private string PathNewFolder { get; set; }

        // private TradeIN _tradeIn;

        private readonly List<Documents.Documents> _documents = new List<Documents.Documents>();

        public AgencyPortfolio()
        {
            // _tradeIn = new TradeIN();
            _person = new Person();
            PathRootFolder = @"D:\Agreements";
            PathNewFolder = "";
            
            _documents.Add(new SaleDirect());
            _documents.Add(new TradeIN());
        }

        public void CreateAgencyPortfolio(string typeContract)
        {
            var destFile = CreateCopyContract();
            
            // if (typeContract == "TradeIN")
            // {
            //     using var tradeIn = new TradeIN();
            //     tradeIn.Open(destFile);
            //     tradeIn.WriteTo();
            //     tradeIn.Save(destFile);
            // }
            foreach (var document in _documents)
            {
                if (typeContract == "TradeIN")
                {
                    document.Open(destFile);
                    document.WriteTo();
                    document.Save(destFile);
                    document.Dispose();
                }
                else if (typeContract == "SaleDirect")
                {
                    document.Open(destFile);
                    document.WriteTo();
                    document.Save(destFile);
                    document.Dispose();
                }
            }
        }

        private string CreateCopyContract()
        {
            PathNewFolder =
                $"{PathRootFolder}\\{_person.ContractIndex}.{_person.Surname}.{_person.Name}.{_person.Car}";
            Directory.CreateDirectory(PathNewFolder);
            
            var sourcePath = @"C:\Avtovek\test.xlsx";
            var destFile = @$"{PathNewFolder}\test.xlsx";
            File.Copy(sourcePath, destFile);
            return destFile;
        }
    }
}