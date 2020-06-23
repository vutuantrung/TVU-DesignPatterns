using PropertyAndMethodDI.Demo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAndMethodDI.Demo.DAL
{
    public class StudentDAL : IStudentDAL
    {
        public Student GetStudentByName( List<Student> list, string name )
        {
            return HelperClass.GetStudentByName( list, name );
        }
    }
}
