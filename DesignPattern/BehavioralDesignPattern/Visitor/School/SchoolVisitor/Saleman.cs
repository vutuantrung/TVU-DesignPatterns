using System;
using System.Collections.Generic;
using System.Text;
using Visitor.School.Enum;
using Visitor.School.SchoolElement;

namespace Visitor.School.SchoolVisitor
{
    public class Saleman : IVisitorSchool
    {
        public string Name { get; set; }

        public Saleman( string name )
        {
            Name = name;
        }

        public void Visit( IElementSchool element )
        {
            if ( element is Kid )
            {
                element.GivingGift( GiftType.Toys );
            }
            else
            {
                element.GivingGift( GiftType.Laptop );
            }
        }
    }
}
