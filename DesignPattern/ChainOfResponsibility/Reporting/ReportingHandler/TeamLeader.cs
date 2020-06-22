using ChainOfResponsibility.Reporting.Class;
using ChainOfResponsibility.Reporting.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Reporting.ReportingHandler
{
    public class TeamLeader : Employee
    {
        private int MAX_LEAVES_CAN_APPROVE = 10;

        public override void ApplyLeave( LeavingRecording record )
        {
            if ( record.NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE )
            {
                ApproveLeave( record );
            }
            else
            {
                _supervisor.ApplyLeave( record );
            }
        }

        private void ApproveLeave( LeavingRecording record )
        {
            record.IsApproved = true;
            record.SectionDecided = SectionType.TeamLeader;
        }
    }
}
