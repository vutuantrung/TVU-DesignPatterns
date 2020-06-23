using EntitesCL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesCL
{
    public class CourseService : ICourseService
    {
        public Course GetCourseByID( int id )
        {
            return new Course
            {
                CoursID = id,
                Description = "Demo course description",
                InstitutionID = 1,
                Title = "Demo Course Title"
            };
        }
    }
}
