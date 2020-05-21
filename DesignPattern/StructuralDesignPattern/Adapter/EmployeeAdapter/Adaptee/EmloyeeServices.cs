using Adapter.EmployeeAdapter.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.EmployeeAdapter.Progress
{
    public static class EmloyeeServices
    {
        public static List<Employee> ConvertToEmployeeList( this string[,] array )
        {
            string id = string.Empty;
            string name = string.Empty;
            string designation = string.Empty;
            string workingHours = string.Empty;
            string salary = string.Empty;

            List<Employee> listEmployee = new List<Employee>();

            for ( int i = 0; i < array.GetLength( 0 ); i++ )
            {
                int j = 0;

                listEmployee.Add(
                    new Employee
                    (
                        id: Convert.ToInt32( array[i, j++] ),
                        name: array[i, j++],
                        designation: array[i, j++],
                        workinghours: Convert.ToDouble( array[i, j++] ),
                        salary: Convert.ToDecimal( array[i, j++] )
                    ) );
            }

            return listEmployee;
        }

        public static Employee FindEmployeeByID( List<Employee> employeeList, int id )
        {
            return employeeList.Find( x => x.ID == id );
        }
    }
}
