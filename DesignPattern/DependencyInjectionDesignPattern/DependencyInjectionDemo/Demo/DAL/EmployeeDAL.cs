using DependencyInjectionDemo.Demo.Class;
using DependencyInjectionDemo.Demo.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo.Demo.DAL
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            return HelperClass.GetDynamicEmployeeList();
        }
    }
}
