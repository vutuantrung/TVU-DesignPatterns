using Iterator.Words.IteratorClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Words.CollectionClass
{
    public class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReserveDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public void AddItem( string item )
        {
            _collection.Add( item );
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator( this, _direction );
        }
    }
}
