using System;
using System.Collections.Generic;
using System.Text;

namespace TestExcel.Contracts.Documents
{
    public class DocumentSalesData
    {
        //private string _sheet;

        //public string Sheet
        //{
        //    get { return _sheet = "Commission"; }
        //}
        public int column;
        public int row;
        public string sheet1; // убрать

        public DocumentSalesData()
        {
            this.row = 8;
            this.column = 2;
            this.sheet1 = "Commission";
        }
    }
}
