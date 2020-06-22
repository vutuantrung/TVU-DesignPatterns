using ChainOfResponsibility.Reporting.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Reporting.ReportingHandler
{
    public abstract class Employee
    {
        protected Employee _supervisor;

        public void SetNextSupervisor( Employee supervisor )
        {
            _supervisor = supervisor;
        }

        public abstract void ApplyLeave( LeavingRecording record );
    }
}
