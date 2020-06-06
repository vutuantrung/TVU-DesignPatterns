using Iterator.EmployeeIterator.Class;
using Iterator.EmployeeIterator.IteratorClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EmployeeIterator.AggregateClass
{
    public interface ICollectionEmployee
    {
        IteratorEmployee CreateIterator();
        Employee GetEmployee( int indexPosition );
        void AddEmployee( Employee employee );
        int Count();
    }
}
