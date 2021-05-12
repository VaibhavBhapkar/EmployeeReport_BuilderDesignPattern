using EmployeeReport_BuilderDesignPattern.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeReport_BuilderDesignPattern.ConcreteBuilder
{
    public class EmployeeReportInExcel:EmployeeReportBuilder
    {
        public override void SetReportContent()
        {
            employeeReport.ReportContent = "Excel Content Section";
        }
        public override void SetReportHeader()
        {
            employeeReport.ReportHeader = "Excel Header";
        }
        public override void SetReportType()
        {
            employeeReport.ReportType = "Excel";
        }
    }
}
