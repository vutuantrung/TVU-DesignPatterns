using Builder.Example2.Builder;
using Builder.Example2.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2
{
    public class ReportDirector
    {
        public Report CreateReport( ReportBuilder reportBuilder )
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}
