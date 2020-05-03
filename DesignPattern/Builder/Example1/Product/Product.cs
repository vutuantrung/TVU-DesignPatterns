using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.Products
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add( string part )
        {
            _parts.Add( part );
        }

        public string ListParts()
        {
            string str = string.Empty;

            for ( int i = 0; i < _parts.Count; i++ )
            {
                str += _parts[i] + ", ";
            }

            str = str.Remove( str.Length - 2 );

            return $"Product parts: { str }.";
        }

    }
}
