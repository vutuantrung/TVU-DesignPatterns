using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EmployeeIterator.Class
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Employee( int id, string name )
        {
            ID = id;
            Name = name;
        }

        public Employee DeepCopy()
        {
            Employee clone = new Employee( this.ID, this.Name );
            return clone;
        }
    }
}
