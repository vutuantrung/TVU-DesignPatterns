using Prototype.PersonInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.PersonService
{
    public class PersonJobService
    {
        private PersonJob _personJob;

        public PersonJobService()
        {
            _personJob = new PersonJob();
        }

        public void AddCompany( string company )
        {
            _personJob.Company = company;
        }

        public void AddJob( string job )
        {
            _personJob.Job = job;
        }

        public void AddSector( string sector )
        {
            _personJob.Sector = sector;
        }

        public void Reset()
        {
            _personJob = new PersonJob();
        }

        public PersonJob GetPersonJob() => _personJob;
    }
}
