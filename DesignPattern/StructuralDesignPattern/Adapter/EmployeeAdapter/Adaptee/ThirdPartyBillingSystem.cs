﻿using Adapter.EmployeeAdapter.Class;
using Adapter.EmployeeAdapter.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.EmployeeAdapter.Adapter
{
    public class ThirdPartyBillingSystem
    {
        // ThridPartyBillingSystem accepts employees information as a List to process each employee salary
        public void ProcessSalary( List<Employee> listEmployee )
        {
            foreach ( Employee employee in listEmployee )
            {
                if ( employee.WorkingHours <= 20.5 )
                {
                    employee.PaySalary = PaySalary.NotPaid;
                    employee.Salary = 0;
                }
                else
                {
                    employee.PaySalary = PaySalary.Paid;
                }
            }
        }
    }
}