using DependencyInjectionDemo.Demo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo.Demo.Helper
{
    public static class HelperClass
    {
        public static List<Employee> GetDynamicEmployeeList()
        {
            try
            {
                List<Employee> list = new List<Employee>();

                list.Add( new Employee { ID = 0, Name = "NameA", Departement = "DepartementA" } );
                list.Add( new Employee { ID = 0, Name = "NameB", Departement = "DepartementB" } );
                list.Add( new Employee { ID = 0, Name = "NameC", Departement = "DepartementC" } );
                list.Add( new Employee { ID = 0, Name = "NameD", Departement = "DepartementD" } );

                return list;
            }
            catch ( Exception ex )
            {
                throw;
            }
        }
    }
}
