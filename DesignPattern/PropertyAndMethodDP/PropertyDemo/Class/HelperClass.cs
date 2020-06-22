using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyAndMethodDI.PropertyDemo.Class
{
    public static class HelperClass
    {
        public static List<Student> CreateDynamicStudenList()
        {
            try
            {
                List<Student> list = new List<Student>();

                list.Add( new Student { ID = 0, Name = "StudentNameA", SchoolName = "SchoolNameA" } );
                list.Add( new Student { ID = 1, Name = "StudentNameB", SchoolName = "SchoolNameA" } );
                list.Add( new Student { ID = 2, Name = "StudentNameC", SchoolName = "SchoolNameD" } );
                list.Add( new Student { ID = 3, Name = "StudentNameD", SchoolName = "SchoolNameD" } );

                return list;
            }
            catch { throw; }
        }

        public static Student GetStudentByName(List<Student> list, string name )
        {
            try
            {
                if ( string.IsNullOrEmpty( name ) ) throw new ArgumentNullException( nameof( name ) );
                if ( list == null ) throw new ArgumentNullException( nameof( list ) );
                if ( list.Count == 0 ) return null;

                var student = list.FirstOrDefault( s => s.Name == name );

                return student;
            }
            catch { throw; }
        }
    }
}
