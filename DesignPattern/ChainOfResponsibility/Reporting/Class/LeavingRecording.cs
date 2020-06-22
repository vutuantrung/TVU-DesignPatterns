using ChainOfResponsibility.Reporting.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Reporting.Class
{
    public class LeavingRecording
    {
        public string EmployeeName { get; set; }

        public int NumberOfDaysLeave { get; set; }

        public bool IsApproved { get; set; }

        public SectionType SectionDecided { get; set; }
    }
}
