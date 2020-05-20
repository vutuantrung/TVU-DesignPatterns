using Adapter.EmployeeAdapter.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.EmployeeAdapter.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary( string[,] employeesArray )
        {
            string id = string.Empty;
            string name = string.Empty;
            string designation = string.Empty;
            string workingHours = string.Empty;
            string salary = string.Empty;

            List<Employee> listEmployee = new List<Employee>();

            for ( int i = 0; i < employeesArray.GetLength( 0 ); i++ )
            {
                int j = 0;

                listEmployee.Add(
                    new Employee
                    (
                        id: Convert.ToInt32( employeesArray[i, j++] ),
                        name: employeesArray[i, j++],
                        designation: employeesArray[i, j++],
                        workinghours: Convert.ToDouble( employeesArray[i, j++] ),
                        salary: Convert.ToDecimal( employeesArray[i, j++] )
                    ) );
            }

            Console.WriteLine( "Adapter converted Array of Employee to List of Employee" );

            thirdPartyBillingSystem.ProcessSalary( listEmployee );
        }
    }
}
