using EmployeeReport_BuilderDesignPattern.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeReport_BuilderDesignPattern.ConcreteBuilder
{
    public class EmployeeReportInPdf:EmployeeReportBuilder
    {
        public override void SetReportContent()
        {
            employeeReport.ReportContent = "PDF Content Section";
        }       
        public override void SetReportHeader()
        {
            employeeReport.ReportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            employeeReport.ReportType = "PDF";
        }
    }
}
