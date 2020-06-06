using Iterator.EmployeeIterator.Class;
using Iterator.EmployeeIterator.IteratorClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EmployeeIterator.AggregateClass
{
    public class CollectionArray : ICollectionEmployee
    {
        private Employee[] _arrayEmployee;
        private int _currentIndex;
        private int _arrayLength;

        public CollectionArray()
        {
            _arrayLength = 5;
            _currentIndex = 0;
            _arrayEmployee = new Employee[_arrayLength];
        }

        public IteratorEmployee CreateIterator()
        {
            return new IteratorEmployee( this );
        }

        public int Count() => _currentIndex;

        public void AddEmployee( Employee employee )
        {
            if ( employee == null ) throw new ArgumentNullException( nameof( employee ) );

            // Enlarge array if there array is full
            if ( _currentIndex >= _arrayLength )
            {
                EnlargeArray();
                //Array.Resize( ref _arrayEmployee, _arrayEmployee.Length + 10 );
            }
            _arrayEmployee[_currentIndex] = employee;

            _currentIndex++;
        }

        private void EnlargeArray()
        {
            // Create new array with new length
            Employee[] newArray = new Employee[_arrayLength + 10];

            // Copy source array to new array
            for ( int i = 0; i < _arrayLength; i++ )
            {
                newArray[i] = _arrayEmployee[i].DeepCopy();
            }

            // Reference original array to new array
            _arrayEmployee = newArray;
            // Update new array length
            _arrayLength = _arrayLength + 10;
        }

        public Employee GetEmployee( int indexPosition )
        {
            if ( indexPosition >= _arrayLength ) throw new IndexOutOfRangeException( "Invalid index." );
            return _arrayEmployee[indexPosition];
        }
    }
}
