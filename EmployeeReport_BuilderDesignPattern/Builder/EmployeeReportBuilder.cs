using EmployeeReport_BuilderDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeReport_BuilderDesignPattern.Builder
{
    public abstract class EmployeeReportBuilder
    {
        protected EmployeeReport employeeReport;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public void CreateNewReport()
        {
            employeeReport = new EmployeeReport();
        }
        public EmployeeReport GetReport()
        {
            return employeeReport;
        }
    }
}
