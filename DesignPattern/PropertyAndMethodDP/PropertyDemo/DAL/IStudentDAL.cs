using PropertyAndMethodDI.PropertyDemo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAndMethodDI.PropertyDemo.DAL
{
    public interface IStudentDAL
    {
        Student GetStudentByName( List<Student> list, string name );
    }
}
