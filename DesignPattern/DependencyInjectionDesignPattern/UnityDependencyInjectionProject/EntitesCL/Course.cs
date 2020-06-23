using System;
using System.Collections.Generic;
using System.Text;

namespace EntitesCL
{
    public class Course
    {
        public int CoursID { get; set; }

        public int InstitutionID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
