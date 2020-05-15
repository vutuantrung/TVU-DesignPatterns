using Builder.Example2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Product
{
    public class Report
    {
        public ReportType ReportType { get; set; } 
        public HeaderType ReportHeader { get; set; } 
        public ContentType ReportContent { get; set; } 
        public FooterType ReportFooter { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine( "Report Type :" + ReportType );
            Console.WriteLine( "Header :" + ReportHeader );
            Console.WriteLine( "Content :" + ReportContent );
            Console.WriteLine( "Footer :" + ReportFooter );
        }
    }
}
