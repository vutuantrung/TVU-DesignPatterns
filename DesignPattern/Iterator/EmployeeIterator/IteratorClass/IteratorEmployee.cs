using Iterator.EmployeeIterator.AggregateClass;
using Iterator.EmployeeIterator.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EmployeeIterator.IteratorClass
{
    public class IteratorEmployee : IIteratorEmployee
    {
        private ICollectionEmployee _collection;
        private int _currentIdx = 0;
        private int _step = 1;

        public IteratorEmployee( ICollectionEmployee collection )
        {
            _collection = collection;
        }

        public bool IsComplete => _currentIdx >= _collection.Count();

        public Employee First()
        {
            _currentIdx = 0;
            return _collection.GetEmployee( _currentIdx );
        }

        public Employee Next()
        {
            _currentIdx += _step;
            if ( this.IsComplete ) return null;
            return _collection.GetEmployee( _currentIdx );
        }
    }
}
