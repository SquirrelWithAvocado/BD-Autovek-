using System;
using Excel.Domain.Entities;
using Excel.Infrastructure;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using Excel.Domain.Entities.Documents;
using Excel.Domain.Services;

namespace Excel.ExcelApplication
{
    public class AgencyPortfolio : Client
    {
        private readonly DocumentSettings _documentSettings = new DocumentSettings();
        private readonly HashSet<Document> _documents = new HashSet<Document>();
        private readonly Client _client;
        
        public AgencyPortfolio(Client client)
        {
            _client = client;
            _documents.Add(new SaleDirect(_client.Name, _client.Surname, _client.Patronymic, _client.PlaceOfBirth, 
                _client.DateOfBirth, indexDocument:0, _client.Passport, _client.Cars));
            _documents.Add(new TradeIN(_client.Name, _client.Surname, _client.Patronymic, _client.PlaceOfBirth, 
                _client.DateOfBirth, indexDocument:1, _client.Passport, _client.Cars));
            _documents.Add(new Result(_client.Name, _client.Surname, _client.Patronymic, _client.PlaceOfBirth, 
                _client.DateOfBirth, indexDocument:2, _client.Passport, _client.Cars));
        }

        public void CreateAgencyPortfolio(int typeContract)
        {
            try
            {
                var countFolders = FilesHandler.GetCountFolders(_documentSettings);
                var newAgencyPortfolio = FilesHandler.GetPathFile
                    (_documentSettings, _client.Name, _client.Surname, _documents, countFolders);
            
                if (_documentSettings.ContractTypes.Length != _documents.Count)
                { throw new DocumentLossException(null); } 
                CreateDocument(typeContract, newAgencyPortfolio);
            }
            catch (DocumentLossException)
            {
                ExceptionHandler.CloseProcess(_documents);
                throw;
            }
        }
    
        private void CreateDocument(int typeContract, string newAgencyPortfolio)
        {
            foreach (var document in _documents)
            {
                if (document.IndexDocument == typeContract)
                    document.DoWorkDocument(newAgencyPortfolio);
                else
                    document.Dispose();
            }
        }
    }
}