using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.PersonInfo
{
    public class PersonAdress
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public PersonAdress GetClone()
        {
            return (PersonAdress)this.MemberwiseClone();
        }
    }
}
