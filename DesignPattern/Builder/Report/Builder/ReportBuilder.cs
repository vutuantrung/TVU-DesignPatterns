using Builder.Example2.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example2.Builder
{
    public abstract class ReportBuilder
    {
        protected Report _reportObject;

        public abstract void SetReportType();

        public abstract void SetReportHeader();

        public abstract void SetReportContent();

        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            _reportObject = new Report();
        }

        public Report GetReport() => _reportObject;
    }
}
