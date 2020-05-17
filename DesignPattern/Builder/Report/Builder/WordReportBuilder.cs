using Builder.Example2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Builder
{
    public class WordReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            _reportObject.ReportContent = ContentType.WordContent;
        }

        public override void SetReportFooter()
        {
            _reportObject.ReportFooter = FooterType.WordFooter;
        }

        public override void SetReportHeader()
        {
            _reportObject.ReportHeader = HeaderType.WordHeader;
        }

        public override void SetReportType()
        {
            _reportObject.ReportType = ReportType.Word;
        }
    }
}
