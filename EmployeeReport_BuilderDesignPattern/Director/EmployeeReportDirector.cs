using EmployeeReport_BuilderDesignPattern.Builder;
using EmployeeReport_BuilderDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeReport_BuilderDesignPattern.Director
{
    public class EmployeeReportDirector
    {
        public EmployeeReport MakeReport(EmployeeReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            return reportBuilder.GetReport();
        }
    }
}
