using ChainOfResponsibility.Reporting.Class;
using ChainOfResponsibility.Reporting.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Reporting.ReportingHandler
{
    public class HR : Employee
    {
        private int MAX_LEAVES_CAN_APPROVE = 30;

        public override void ApplyLeave( LeavingRecording record )
        {
            if ( record.NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE )
            {
                ApproveLeave( record );
            }
            else
            {
                Decline( record );
            }
        }

        private void Decline( LeavingRecording record )
        {
            record.IsApproved = false;
            record.SectionDecided = SectionType.HR;
        }

        private void ApproveLeave( LeavingRecording record )
        {
            record.IsApproved = true;
            record.SectionDecided = SectionType.HR;
        }
    }
}
