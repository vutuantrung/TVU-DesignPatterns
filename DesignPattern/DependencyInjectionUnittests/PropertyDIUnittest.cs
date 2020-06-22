﻿using NUnit.Framework;
using PropertyAndMethodDI.PropertyDemo.BL;
using PropertyAndMethodDI.PropertyDemo.Class;
using PropertyAndMethodDI.PropertyDemo.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionUnittests
{
    [TestFixture]
    class PropertyDIUnittest
    {
        [Test]
        public void Test_Demo()
        {
            List<Student> list = new List<Student>();

            list.Add( new Student { ID = 0, Name = "StudentNameA", SchoolName = "SchoolNameA" } );
            list.Add( new Student { ID = 1, Name = "StudentNameB", SchoolName = "SchoolNameA" } );
            list.Add( new Student { ID = 2, Name = "StudentNameC", SchoolName = "SchoolNameD" } );
            list.Add( new Student { ID = 3, Name = "StudentNameD", SchoolName = "SchoolNameD" } );

            StudentBL studentBL = new StudentBL();
            studentBL.StudentDataObject = new StudentDAL();

            {
                var s = studentBL.GetStudent( list, "StudentNameA" );
                Assert.That( s.ID, Is.EqualTo( 0 ) );
                Assert.That( s.Name, Is.EqualTo( "StudentNameA" ) );
                Assert.That( s.SchoolName, Is.EqualTo( "SchoolNameA" ) );
            }

            {
                var s = studentBL.GetStudent( list, "StudentNameC" );
                Assert.That( s.ID, Is.EqualTo( 2 ) );
                Assert.That( s.Name, Is.EqualTo( "StudentNameC" ) );
                Assert.That( s.SchoolName, Is.EqualTo( "SchoolNameD" ) );
            }

            {
                var s = studentBL.GetStudent( list, "StudentC" );
                Assert.That( s, Is.EqualTo(null) );
            }

            {
                Assert.Throws<ArgumentNullException>( () => studentBL.GetStudent( list, string.Empty ), "Name of name" );
                Assert.Throws<ArgumentNullException>( () => studentBL.GetStudent( null, "StudentA" ), "Name of list" );
            }
        }
    }
}