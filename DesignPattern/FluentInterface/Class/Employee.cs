using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterface.Class
{
    public class Employee
    {
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Departement { get; set; }

        public string Address { get; set; }
    }

    public class FluentEmployee
    {
        private Employee _employee;

        public FluentEmployee Initialize()
        {
            _employee = new Employee();
            return this;
        }

        public FluentEmployee SetFullName( string fullName )
        {
            _employee.FullName = fullName;
            return this;
        }

        public FluentEmployee SetDateOfBirth( DateTime dateOfBirth )
        {
            _employee.DateOfBirth = dateOfBirth;
            return this;
        }

        public FluentEmployee SetDepartement( string departement )
        {
            _employee.Departement = departement;
            return this;
        }

        public FluentEmployee SetAddress( string address )
        {
            _employee.Address = address;
            return this;
        }

        public Employee Build()
        {
            return _employee;
        }
    }
}
