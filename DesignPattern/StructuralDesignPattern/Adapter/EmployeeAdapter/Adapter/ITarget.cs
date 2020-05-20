using Adapter.EmployeeAdapter.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.EmployeeAdapter.Adapter
{
    public interface ITarget
    {
        void ProcessCompanySalary( string[,] employeesArray );

        List<Employee> GetListEmployee();
    }
}
