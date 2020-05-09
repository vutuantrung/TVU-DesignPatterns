using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.Products
{
    public class Product
    {
        private List<object> _parts;

        private int _count;

        public Product()
        {
            _parts = new List<object>();
            _count = 0;
        }

        public int Count => _parts.Count;

        public List<object> ListPart => _parts;

        public void Add( object part )
        {
            _parts.Add( part );
            _count++;
        }
    }
}
