using Builder.Example2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Builder
{
    public class PDFReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            _reportObject.ReportContent = ContentType.PDFContent;
        }

        public override void SetReportFooter()
        {
            _reportObject.ReportFooter = FooterType.PDFFooter;
        }

        public override void SetReportHeader()
        {
            _reportObject.ReportHeader = HeaderType.PDFHeader;
        }

        public override void SetReportType()
        {
            _reportObject.ReportType = ReportType.PDF;
        }
    }
}
