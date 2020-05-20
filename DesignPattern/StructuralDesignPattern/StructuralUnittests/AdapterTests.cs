using Adapter.EmployeeAdapter.Adapter;
using Adapter.EmployeeAdapter.Class;
using Adapter.EmployeeAdapter.Enum;
using Adapter.EmployeeAdapter.Progress;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralUnittests
{
    [TestFixture]
    class AdapterTests
    {
        [Test]
        public void test_employee()
        {
            string[,] employeesArray = new string[5, 5]
            {
                {"101","John","SE", "31.5","10000"},
                {"102","Smith","SE", "12.7","20000"},
                {"103","Dev","SSE", "21.6","30000"},
                {"104","Pam","SE", "23.8","40000"},
                {"105","Sara","SSE", "50.5","50000"}
            };

            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary( employeesArray );

            List<Employee> list = target.GetListEmployee();

            {
                Employee employee = EmloyeeServices.FindEmployeeByID( list, 101 );

                Assert.That( employee.ID == 101 );
                Assert.That( employee.Name == "John" );
                Assert.That( employee.Designation == "SE" );
                Assert.That( employee.WorkingHours == 31.5 );
                Assert.That( employee.PaySalary == PaySalary.Paid );
                Assert.That( employee.Salary == 10000 );
            }

            {
                Employee employee = EmloyeeServices.FindEmployeeByID( list, 102 );

                Assert.That( employee.ID == 102 );
                Assert.That( employee.Name == "Smith" );
                Assert.That( employee.Designation == "SE" );
                Assert.That( employee.WorkingHours == 12.7 );
                Assert.That( employee.PaySalary == PaySalary.NotPaid );
                Assert.That( employee.Salary == 0 );
            }

            {
                Employee employee = EmloyeeServices.FindEmployeeByID( list, 103 );

                Assert.That( employee.ID == 103 );
                Assert.That( employee.Name == "Dev" );
                Assert.That( employee.Designation == "SSE" );
                Assert.That( employee.WorkingHours == 21.6 );
                Assert.That( employee.PaySalary == PaySalary.Paid );
                Assert.That( employee.Salary == 30000 );
            }

            {
                Employee employee = EmloyeeServices.FindEmployeeByID( list, 104 );

                Assert.That( employee.ID == 104 );
                Assert.That( employee.Name == "Pam" );
                Assert.That( employee.Designation == "SE" );
                Assert.That( employee.WorkingHours == 23.8 );
                Assert.That( employee.PaySalary == PaySalary.Paid );
                Assert.That( employee.Salary == 40000 );
            }

            {
                Employee employee = EmloyeeServices.FindEmployeeByID( list, 105 );

                Assert.That( employee.ID == 105 );
                Assert.That( employee.Name == "Sara" );
                Assert.That( employee.Designation == "SSE" );
                Assert.That( employee.WorkingHours == 50.5 );
                Assert.That( employee.PaySalary == PaySalary.Paid );
                Assert.That( employee.Salary == 50000 );
            }

            {
                Employee employee = EmloyeeServices.FindEmployeeByID( list, 106 );

                Assert.That( employee == null );
            }

        }
    }
}
