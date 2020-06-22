using PropertyAndMethodDI.PropertyDemo.Class;
using PropertyAndMethodDI.PropertyDemo.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAndMethodDI.PropertyDemo.BL
{
    public class StudentBL
    {
        private IStudentDAL _studentDAL;

        public IStudentDAL StudentDataObject
        {
            set
            {
                this._studentDAL = value;
            }
            get
            {
                if ( StudentDataObject == null ) throw new Exception( "Student DAL is not initialized" );
                return _studentDAL;
            }
        }

        public Student GetStudent( List<Student> list, string name )
        {
            try
            {
                return _studentDAL.GetStudentByName( list, name );
            }
            catch { throw; }
        }
    }
}
