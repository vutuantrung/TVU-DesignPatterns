using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Words.IteratorClass
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Return key of the current element
        public abstract int Key();

        // Return current element
        public abstract object Current();

        // Move foward to next element
        public abstract bool MoveNext();

        // Rewinds the Iterator to the first element
        public abstract void Reset();
    }
}
