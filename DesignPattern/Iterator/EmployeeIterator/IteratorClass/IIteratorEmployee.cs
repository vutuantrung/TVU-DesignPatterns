using Iterator.EmployeeIterator.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EmployeeIterator.IteratorClass
{
    public interface IIteratorEmployee
    {
        Employee First();
        Employee Next();
        bool IsComplete { get; }
    }
}
