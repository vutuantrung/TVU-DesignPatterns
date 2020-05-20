using Prototype.Enum;
using Prototype.PersonInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.PersonService
{
    public class PersonRelationshipService
    {
        private PersonRelationship _relationship;

        public PersonRelationshipService()
        {
            _relationship = new PersonRelationship( EnumRelationship.Unknown );
        }

        public void SetRelationship( EnumRelationship relationship )
        {
            _relationship.Relationship = relationship;
        }

        public void Reset()
        {
            _relationship = new PersonRelationship( EnumRelationship.Unknown );
        }

        public PersonRelationship GetPersonRelationship() => _relationship;
    }
}
