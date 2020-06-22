using PropertyAndMethodDI.Demo.Class;
using PropertyAndMethodDI.Demo.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAndMethodDI.Demo.BL
{
    public class StudentBL
    {
        private IStudentDAL _studentDAL;

        /// <summary>
        /// Method using dependency injection
        /// </summary>
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

        /// <summary>
        /// Method using dependency injection variable
        /// </summary>
        /// <param name="list">Student list</param>
        /// <param name="name">Student' name need to be searched</param>
        /// <returns>Student with spicific name</returns>
        public Student GetStudent( List<Student> list, string name )
        {
            try
            {
                return _studentDAL.GetStudentByName( list, name );
            }
            catch { throw; }
        }

        /// <summary>
        /// Method which is injected a dependency
        /// </summary>
        /// <param name="studentDAL">Dependency injected</param>
        /// <param name="list">Student list</param>
        /// <param name="name">Student' name need to be searched</param>
        /// <returns>Student with spicific name</returns>
        public Student GetStudent( IStudentDAL studentDAL, List<Student> list, string name )
        {
            try
            {
                return studentDAL.GetStudentByName( list, name );
            }
            catch { throw; }
        }
    }
}
