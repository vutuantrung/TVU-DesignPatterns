using EntitesCL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesCL
{
    public interface ICourseService
    {
        Course GetCourseByID( int id );
    }
}
