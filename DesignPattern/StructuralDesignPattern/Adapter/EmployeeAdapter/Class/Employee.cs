using Adapter.EmployeeAdapter.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.EmployeeAdapter.Class
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }

        public decimal Salary { get; set; }

        public PaySalary PaySalary { get; set; }

        public double WorkingHours { get; set; }

        public Employee( int id, string name, string designation, double workinghours, decimal salary )
        {
            ID = id;
            Name = name;
            Designation = designation;
            Salary = salary;
            PaySalary = PaySalary.NotPaid;
            WorkingHours = workinghours;
        }
    }
}
