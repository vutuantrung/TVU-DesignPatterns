using System;
using System.Collections.Generic;
using System.Text;
using Visitor.School.Enum;
using Visitor.School.SchoolElement;

namespace Visitor.School.SchoolVisitor
{
    // These are the subclasses that implement each operation declared by the IVisitor interface.
    // Each operation implements a fragment of the algorithm defined for the corresponding class or object in the structure.
    public class Doctor : IVisitorSchool
    {
        public string Name { get; set; }

        public Doctor( string name )
        {
            Name = name;
        }

        public void Visit( IElementSchool element )
        {
            if ( element is Kid )
            {
                element.GivingMedication( MedicineType.ForKid );
            }
            else
            {
                element.GivingMedication( MedicineType.ForAdult );
            }
        }
    }
}
