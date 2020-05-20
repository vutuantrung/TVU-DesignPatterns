using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Enum
{
    public enum ReportType
    {
        Excel,
        PDF,
        Word,
        PowerPoint
    }

    public enum HeaderType
    {
        ExcelHeader,
        PDFHeader,
        WordHeader,
        PowerPointHeader
    }

    public enum ContentType
    {
        ExcelContent,
        PDFContent,
        WordContent,
        PowerPointContent
    }

    public enum FooterType
    {
        ExcelFooter,
        PDFFooter,
        WordFooter,
        PowerPointFooter
    }
}
