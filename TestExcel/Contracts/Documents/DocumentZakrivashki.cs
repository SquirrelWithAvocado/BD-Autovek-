using System;
using System.Collections.Generic;
using System.Text;

namespace TestExcel.Contracts.Documents
{
    public class DocumentZakrivashki
    {
        public string column;
        public int row;

        public DocumentZakrivashki()
        {
            this.row = 8;
            this.column = "B";
        }
    }
}
