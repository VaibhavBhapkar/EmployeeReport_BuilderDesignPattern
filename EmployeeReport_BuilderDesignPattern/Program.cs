using EmployeeReport_BuilderDesignPattern.ConcreteBuilder;
using EmployeeReport_BuilderDesignPattern.Director;
using EmployeeReport_BuilderDesignPattern.Product;
using System;

namespace EmployeeReport_BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeReport report;
            EmployeeReportDirector reportDirector = new EmployeeReportDirector();

            EmployeeReportInPdf pdfReport = new EmployeeReportInPdf();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayEmployeeReport();

            Console.WriteLine("-------------------");

            EmployeeReportInExcel excelReport = new EmployeeReportInExcel();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayEmployeeReport();
        }
    }
}
