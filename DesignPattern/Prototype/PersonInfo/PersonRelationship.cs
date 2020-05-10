using Prototype.Enum;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Prototype.PersonInfo
{
    public class PersonRelationship
    {
        public EnumRelationship Relationship { get; set; }

        public PersonRelationship(EnumRelationship relationShip)
        {
            Relationship = relationShip;
        }
    }
}
