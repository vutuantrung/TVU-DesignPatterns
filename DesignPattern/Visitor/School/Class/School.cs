using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Visitor.School.SchoolElement;
using Visitor.School.SchoolVisitor;

namespace Visitor.School.Class
{
    // This is a class that holds all the elements (i.e. a collection of kids) and provides a high-level interface that allows the visitor to visit all the elements.
    public class School
    {
        private List<IElementSchool> _kids = new List<IElementSchool>();
        private List<IElementSchool> _teachers = new List<IElementSchool>();

        public School()
        {
            _kids.Add( new Kid( "StudentA" ) );
            _kids.Add( new Kid( "StudentB" ) );
            _kids.Add( new Kid( "StudentC" ) );
            _kids.Add( new Kid( "StudentD" ) );

            _teachers.Add( new Teacher( "TeacherA" ) );
            _teachers.Add( new Teacher( "TeacherB" ) );
            _teachers.Add( new Teacher( "TeacherC" ) );
        }

        public List<IElementSchool> GetKids => _kids;

        public List<IElementSchool> GetTeachers => _teachers;

        public void PerformExamination( IVisitorSchool doctor )
        {
            foreach ( IElementSchool kid in _kids )
            {
                doctor.Visit( kid );
            }

            foreach ( IElementSchool teacher in _teachers )
            {
                doctor.Visit( teacher );
            }
        }

        public void PerformSaling( IVisitorSchool saleman )
        {
            foreach ( IElementSchool kid in _kids )
            {
                saleman.Visit( kid );
            }

            foreach ( IElementSchool teacher in _teachers )
            {
                saleman.Visit( teacher );
            }
        }
    }
}
