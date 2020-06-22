using ChainOfResponsibility.Reporting.ReportingHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Reporting.Class
{
    public class ReportingSection
    {
        TeamLeader _teamLeader;
        ProjectLeader _projectLeader;
        HR _hr;

        public ReportingSection()
        {
            _teamLeader = new TeamLeader();
            _projectLeader = new ProjectLeader();
            _hr = new HR();

            _teamLeader.SetNextSupervisor( _projectLeader );
            _projectLeader.SetNextSupervisor( _hr );
            _hr.SetNextSupervisor( null );
        }

        public void ApproveLeavingRecord( LeavingRecording record )
        {
            _teamLeader.ApplyLeave( record );
        }
    }
}
