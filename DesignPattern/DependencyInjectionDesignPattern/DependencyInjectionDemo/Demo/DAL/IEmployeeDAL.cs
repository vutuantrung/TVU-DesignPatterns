using DependencyInjectionDemo.Demo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo.Demo.DAL
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
