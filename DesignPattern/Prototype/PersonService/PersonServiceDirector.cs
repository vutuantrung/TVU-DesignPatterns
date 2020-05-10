using Prototype.Enum;
using Prototype.PersonInfo;
using Prototype.PersonSpace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.PersonService
{
    public class PersonServiceDirector
    {
        public Person _person;

        public Person Person
        {
            set { _person = value; }
        }

        public void Reset()
        {
            _person = null;
        }

        public void SetPersonAdress( PersonAdress personAdress )
        {
            SetPersonAdress
            (
                country: personAdress.Country,
                city: personAdress.City,
                district: personAdress.District,
                street: personAdress.Street,
                number: personAdress.Number
            );
        }

        public void SetPersonAdress( string country, string city, string district, string street, int number )
        {
            PersonAdressService service = new PersonAdressService();
            service.Reset();
            service.AddCountry( country );
            service.AddCity( city );
            service.AddDistrict( district );
            service.AddStreet( street );
            service.AddNumber( number );

            _person.PersonAdress = service.GetAdress();
        }

        public void SetPersonJob( PersonJob personJob )
        {
            SetPersonJob
            (
                company: personJob.Company,
                job: personJob.Job,
                sector: personJob.Sector
            );
        }

        public void SetPersonJob( string company, string job, string sector )
        {
            PersonJobService service = new PersonJobService();
            service.Reset();
            service.AddCompany( company );
            service.AddJob( job );
            service.AddSector( sector );

            _person.PersonJob = service.GetPersonJob();
        }

        public void SetPersonRelationship( PersonRelationship relationship )
        {
            SetPersonRelationship( relationship.Relationship );
        }

        public void SetPersonRelationship( EnumRelationship relationship )
        {
            PersonRelationshipService service = new PersonRelationshipService();
            service.Reset();
            service.SetRelationship( relationship: relationship );

            _person.RelationShip = service.GetPersonRelationship();
        }
    }
}
