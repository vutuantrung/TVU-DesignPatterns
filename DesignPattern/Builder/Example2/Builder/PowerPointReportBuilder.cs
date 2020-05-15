using Builder.Example2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Builder
{
    public class PowerPointReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            _reportObject.ReportContent = ContentType.PowerPointContent;
        }

        public override void SetReportFooter()
        {
            _reportObject.ReportFooter = FooterType.PowerPointFooter;
        }

        public override void SetReportHeader()
        {
            _reportObject.ReportHeader = HeaderType.PowerPointHeader;
        }

        public override void SetReportType()
        {
            _reportObject.ReportType = ReportType.PowerPoint;
        }
    }
}
