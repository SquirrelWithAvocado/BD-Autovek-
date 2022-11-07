using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;

namespace TestExcel
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start prog");
            Contracts.ContractTypeHelper.PridymatNazvanie();
        }
    }
}