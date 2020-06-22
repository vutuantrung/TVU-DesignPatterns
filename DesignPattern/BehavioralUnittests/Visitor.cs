using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Visitor.School.Class;
using Visitor.School.Enum;
using Visitor.School.SchoolElement;
using Visitor.School.SchoolVisitor;

namespace BehavioralUnittests
{
    [TestFixture]
    class Visitor
    {
        [Test]
        public void Test_School()
        {
            IVisitorSchool doctor = new Doctor( "Doctor Strange" );
            IVisitorSchool saleman = new Saleman( "Jordan Belfort" );

            School school = new School();

            school.PerformExamination( doctor );
            school.PerformSaling( saleman );

            foreach ( Kid kid in school.GetKids )
            {
                Assert.That( kid.GetGift, Is.EqualTo( GiftType.Toys ) );
                Assert.That( kid.GetMedicine, Is.EqualTo( MedicineType.ForKid ) );
            }

            foreach ( Teacher teacher in school.GetTeachers )
            {
                Assert.That( teacher.GetGift, Is.EqualTo( GiftType.Laptop ) );
                Assert.That( teacher.GetMedicine, Is.EqualTo( MedicineType.ForAdult ) );
            }
        }
    }
}
