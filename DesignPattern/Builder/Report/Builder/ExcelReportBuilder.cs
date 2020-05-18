using Builder.Example2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Builder
{
    // The class whose members are inherited is called the base class.
    // The class that inherits the members of the base class is called the derived class.

    public class ExcelReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            _reportObject.ReportContent = ContentType.ExcelContent;
        }

        public override void SetReportFooter()
        {
            _reportObject.ReportFooter = FooterType.ExcelFooter;
        }

        public override void SetReportHeader()
        {
            _reportObject.ReportHeader = HeaderType.ExcelHeader;
        }

        public override void SetReportType()
        {
            _reportObject.ReportType = ReportType.Excel;
        }
    }
}
