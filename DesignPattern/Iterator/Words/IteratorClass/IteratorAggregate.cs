using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Words.IteratorClass
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
