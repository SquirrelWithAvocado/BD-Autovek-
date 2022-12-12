using Excel.Interfaces;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace Excel.Domain.Models.Documents
{
    public abstract class Documents : IDocument, IDisposable
    {
        protected Workbook Workbook;
        protected Workbooks WorkbookTemporary;
        protected Sheets Sheets;
        protected Worksheet Worksheet;
        protected Application Excel;

        protected Documents()
        {
            Excel = new Application();
        }

        public bool Open(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Excel.DisplayAlerts = false;
                    WorkbookTemporary = Excel.Workbooks;
                    Workbook = WorkbookTemporary.Open(filePath);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }
        public abstract bool WriteTo();

        public bool Save(string filePath)
        {
            try
            {
                Workbook.Save();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        public void Dispose()
        {
            Console.WriteLine("Delete proc");

            uint processId;
            GetWindowThreadProcessId((IntPtr)Excel.Hwnd, out processId);
            try
            {
                Process.GetProcessById((int)processId).Kill();
            }
            catch (ArgumentException) { }
            catch (Win32Exception) { }
        }
        
        [DllImport("user32")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
    }
}