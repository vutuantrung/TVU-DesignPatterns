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

        #region Person Adress
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
            service.AddCountry( country );
            service.AddCity( city );
            service.AddDistrict( district );
            service.AddStreet( street );
            service.AddNumber( number );

            _person.PersonAdress = service.GetAdress();
        }

        public void InitializePersonAdress()
        {
            PersonAdressService service = new PersonAdressService();
            service.Reset();
            _person.PersonAdress = service.GetAdress();
        }
        #endregion


        #region Set Person job
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
            service.AddCompany( company );
            service.AddJob( job );
            service.AddSector( sector );

            _person.PersonJob = service.GetPersonJob();
        }

        public void InitializePersonJob()
        {
            PersonJobService service = new PersonJobService();
            service.Reset();
            _person.PersonJob = service.GetPersonJob();
        }
        #endregion

        #region Set person relationship
        public void SetPersonRelationship( PersonRelationship relationship )
        {
            SetPersonRelationship( relationship.Relationship );
        }

        public void SetPersonRelationship( EnumRelationship relationship )
        {
            PersonRelationshipService service = new PersonRelationshipService();
            service.SetRelationship( relationship: relationship );

            _person.RelationShip = service.GetPersonRelationship();
        }

        public void InitializePersonRelationship()
        {
            PersonRelationshipService service = new PersonRelationshipService();
            service.Reset();
            _person.RelationShip = service.GetPersonRelationship();
        }
        #endregion
    }
}
