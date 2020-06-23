using DependencyInjectionDemo.Demo.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo.Demo.BL
{
    // Business logic
    public class EmployeeBL
    {
        // If we create EmployeeDAL employeeDAL = new EmployeeDAL() here,
        // It will create a tight coupling because the EmployeeDAL is tightly coupled with the EmployeeBL class

        /// <summary>
        /// In the above example, we created one constructor which accepts one parameter of the dependency object type.
        /// The point that you need to keep focus is, the parameter of the constructor is of the type interface, not the concrete class.
        /// Now, this parameter can accept any concrete class object which implements this interface.
        /// 
        /// So here in the EmployeeBL class, we are not creating the object of the EmployeeDAL class.
        /// Instead, we are passing it as a parameter to the constructor of the EmployeeBL class.
        /// As we are injecting the dependency object through the constructor, it is called as Constructor Dependency Injection in C#.
        /// </summary>

        IEmployeeDAL _employeeDAL;


        public EmployeeBL( IEmployeeDAL employeeDAL )
        {
            _employeeDAL = employeeDAL;
        }

        public void GetAllEmployee()
        {
            var employees = _employeeDAL.SelectAllEmployees();
        }
    }
}