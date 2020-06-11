using Iterator.Words.CollectionClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Words.IteratorClass
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;

        private bool _reserve = false;

        private int _position = 0;

        public AlphabeticalOrderIterator( WordsCollection collection, bool reserve = false )
        {
            _collection = collection;
            _reserve = reserve;

            if ( reserve )
            {
                _position = collection.GetItems().Count - 1;
            }
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position += _reserve ? -1 : 1;
            if ( updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count )
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _reserve ? _collection.GetItems().Count - 1 : 0;
        }
    }
}
