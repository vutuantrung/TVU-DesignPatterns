using Prototype.PersonInfo;
using Prototype.PersonService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.PersonSpace
{
    public class Person
    {
        public string Name { get; set; }

        public string PersonID { get; set; }

        public PersonAdress PersonAdress { get; set; }

        public PersonJob PersonJob { get; set; }

        public PersonRelationship RelationShip { get; set; }

        public Person( string name, string personId )
        {
            Name = name;
            PersonID = personId;
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.PersonID = string.Copy( this.PersonID );

            PersonServiceDirector director = new PersonServiceDirector();
            director.Person = clone;
            director.SetPersonAdress( this.PersonAdress );
            director.SetPersonJob( this.PersonJob );
            director.SetPersonRelationship( this.RelationShip );

            return clone;
        }
    }
}
