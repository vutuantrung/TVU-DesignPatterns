using Iterator.EmployeeIterator.Class;
using Iterator.EmployeeIterator.IteratorClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EmployeeIterator.AggregateClass
{
    public class CollectionList : ICollectionEmployee
    {
        private List<Employee> _listEmployee = new List<Employee>();

        public IteratorEmployee CreateIterator()
        {
            return new IteratorEmployee( this );
        }

        public int Count() => _listEmployee.Count;

        public void AddEmployee( Employee employee )
        {
            if ( employee == null ) throw new ArgumentNullException( nameof( employee ) );
            _listEmployee.Add( employee );
        }

        public Employee GetEmployee( int indexPosition )
        {
            if ( indexPosition >= _listEmployee.Count ) throw new IndexOutOfRangeException( "Invalid index." );
            return _listEmployee[indexPosition];
        }
    }
}
