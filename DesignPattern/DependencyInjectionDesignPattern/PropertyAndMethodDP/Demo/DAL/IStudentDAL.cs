using PropertyAndMethodDI.Demo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAndMethodDI.Demo.DAL
{
    public interface IStudentDAL
    {
        Student GetStudentByName( List<Student> list, string name );
    }
}
