using Prototype.PersonInfo;
using Prototype.PersonSpace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.PersonService
{
    public class PersonAdressService
    {
        private PersonAdress _personAdress;

        public PersonAdressService()
        {
            _personAdress = new PersonAdress();
        }

        public void AddCountry( string country )
        {
            _personAdress.Country = country;
        }

        public void AddCity( string city )
        {
            _personAdress.City = city;
        }

        public void AddDistrict( string district )
        {
            _personAdress.District = district;
        }

        public void AddNumber( int number )
        {
            _personAdress.Number = number;
        }

        public void AddStreet( string street )
        {
            _personAdress.Street = street;
        }

        public void Reset()
        {
            _personAdress = new PersonAdress();
        }

        public PersonAdress GetAdress() => _personAdress;
    }
}
