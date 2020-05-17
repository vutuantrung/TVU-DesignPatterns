using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.PersonInfo
{
    public class PersonJob
    {
        public string Company { get; set; }

        public string Job { get; set; }

        public string Sector { get; set; }

        public PersonJob GetClone()
        {
            return (PersonJob)this.MemberwiseClone();
        }
    }
}
