using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeReport_BuilderDesignPattern.Product
{
    public class EmployeeReport
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportContent { get; set; }
        public void DisplayEmployeeReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
        }
    }
}
